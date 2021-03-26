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
namespace ConsoleCalculator
{
    public class ConsoleManager
    {

        public static Calculator _calculator = new Calculator(new CalculatorBuilder());
        ConsoleEventManager _consoleEventManager = new ConsoleEventManager();
        EventRegister _consoleEvent = new EventRegister(_calculator);
        ConsoleCalcObserver _calculationObserver = new ConsoleCalcObserver();

        public void Start()
        {
            bool _finalDecision = true;
            Console.WriteLine("Welcome to the Console Calculator. Please enter which operation you wish to perform: ");
            while (_finalDecision)
            {
                Console.WriteLine("Options: ('add', 'sub', 'mul', 'div', 'pow')");
                var _action = _consoleEventManager.UserInputAction();
                double _firstInput = _consoleEventManager.UserInputDouble();

                double _secondInput = _consoleEventManager.UserInputDouble();

                _consoleEventManager.DivideByZeroException(_action, _secondInput);
                PerformCalculation(_firstInput, _secondInput, _action);

                //GetCalculationList();
                //DisplayUserInputs();
                _finalDecision = FinalDecision();
                

            }
        }

        bool FinalDecision()

        {
            Console.WriteLine("Continue? 'Yes' or 'No'?");
            string _decision = Console.ReadLine();
            _decision.ToLower();
            if (_decision == "yes")
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
        /*
        public void GetCalculationList()
        {
            RegisterDisplayCalculationEvent();
            var _list = _calculator._calculatorBuilder.GetList();

        }
        */

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
