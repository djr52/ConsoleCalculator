using System;
using System.Collections.Generic;
using MyCalculator.EventPublisher;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Builders;
using MyCalculator;
using ConsoleEventHandler.ConsolePublisher;
using ConsoleCalculator.Subscribers;
using ConsoleEventHandler;
using ConsoleCalculator.RegisterEvents;
using ConsoleEventHandler.Observers;
using ConsoleCalculator.Factory;
namespace ConsoleCalculator
{
    public class ConsoleManager
    {
        public static CalculatorBuilder _calculatorBuilder = new CalculatorBuilder();
        public static Calculator _calculator = new Calculator(_calculatorBuilder);
        ConsoleEventManager _consoleEventManager = new ConsoleEventManager();
        EventRegister _consoleEvent = new EventRegister(_calculator);
        ConsoleCalcObserver _calculationObserver = new ConsoleCalcObserver();
        DisplayListOfCalculations displayCalcList = new DisplayListOfCalculations();

        public void Start()
        {
            bool _finalDecision = true;
            _consoleEventManager.ConsoleStartUp();
            while (_finalDecision)
            {
                var _action = _consoleEventManager.UserInputAction();
                double _firstInput = _consoleEventManager.UserInputDouble();

                double _secondInput = _consoleEventManager.UserInputDouble();

                _consoleEventManager.DivideByZeroException(_action, _secondInput);
                PerformCalculation(_firstInput, _secondInput, _action);

                MenuOptions();
                //_finalDecision = FinalDecision(); //break; can work as well
                

            }
        }

        bool FinalDecision()

        {
            Console.WriteLine("Continue? (y/n) ");
            return Decision();

        }
        void MenuOptions()
        {
            /*
            Console.WriteLine("Display calculation list? (y/n) ");
            if (Decision())
            {
                GetCalculationList();
            }
            */
            Console.WriteLine("Select an Option");
            var inputOp = new InputOptionFactory();
            string _option = Console.ReadLine();
            inputOp.getOptionStrategy(_option).getOption();
          
        }
        bool Decision()
        {
            string _decision = Console.ReadLine();
            _decision.ToLower();
            if (_decision == "y")
            {

                return true;

            }
            return false;
        }

        public void PerformCalculation(double firstInput, double secondInput, Func<double, double, double> action)
        {
            _consoleEventManager.Attach(_calculationObserver);
            _consoleEvent.RegisterDisplayCalculationEvent();
            var _result = _calculator.CreateCalculation(firstInput, secondInput, action);
            _consoleEventManager.Notify();
            _consoleEvent.UnregisterDisplayCalculationEvent();
            _consoleEventManager.Detach(_calculationObserver);
        }
        
        public void GetCalculationList()
        {

            _calculator._calcEvent.UsingCalculator += displayCalcList.OnCalculator;
            _calculator._calcEvent.UseCalculator(_calculatorBuilder);


        }


        void StoreUserInput()
        {
            _consoleEventManager._eventRegister.RegisterStoreUserInputEvent();
        }
        public void DisplayUserInputs()
        {
            _consoleEventManager.DisplayLastInput();
            _consoleEventManager._eventRegister.UnregisterStoreUserInputEvent();
        }


    }
}
