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
namespace ConsoleCalculator
{
    public class ConsoleManager
    {

        public static Calculator _calculator = new Calculator(new CalculatorBuilder());
        ConsoleEventManager _consoleEventManager = new ConsoleEventManager();
        EventRegister _consoleEvent = new EventRegister(_calculator);

        public void Start()
        {
            bool _decision = true;
            Console.WriteLine("Welcome to the Console Calculator. Please enter which operation you wish to perform: ");
            
            while (_decision)
            {
                Console.WriteLine("Options: ('add', 'sub', 'mul', 'div', 'pow')");
                var _action = _consoleEventManager.UserInputAction();
                double _firstInput = _consoleEventManager.UserInputDouble();

                double _secondInput = _consoleEventManager.UserInputDouble();

                PerformCalculation(_firstInput, _secondInput, _action);
                //GetCalculationList();
                //DisplayUserInputs();
                _decision = FinalDecision();
                

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

            _consoleEvent.RegisterDisplayCalculationEvent();
            var _result = _calculator.CreateCalculation(firstInput, secondInput, action);
            _consoleEvent.UnregisterDisplayCalculationEvent();

        }
        /*
        public void GetCalculationList()
        {
            RegisterDisplayCalculationEvent();
            var _list = _calculator._calculatorBuilder.GetList();

        }
        */

        /*
        void RegisterListOfCalculationsEvent()
        {
            _calculator._calcEvent.UsingCalculator += displayCalcList.OnCalculator;
        }
        */
        void StoreUserInput()
        {
            _consoleEventManager.RegisterStoreUserInputEvent();
            //_consoleEvent.UserInput += storeUserInput.OnUserInput;
        }
        public void DisplayUserInputs()
        {
            _consoleEventManager.DisplayUserInputs();
            _consoleEventManager.UnregisterStoreUserInputEvent();
        }


    }
}
