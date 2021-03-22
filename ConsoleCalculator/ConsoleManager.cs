using System;
using System.Collections.Generic;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Builders;
using MyCalculator;
using ConsoleEventHandler.ConsolePublisher;
using ConsoleCalculator.Subscribers;
using ConsoleEventHandler;
namespace ConsoleCalculator
{
    public class ConsoleManager
    {
        Calculator _calculator = new Calculator(new CalculatorBuilder());
        ConsoleEventManager _consoleEvent = new ConsoleEventManager();
        public void Start()
        {
            Console.WriteLine("Welcome to the Console Calculator. Please enter which operation you wish to perform: ");
            
            while (true)
            {
                Console.WriteLine("Options: ('add', 'sub', 'mul', 'div')");
                var _action = _consoleEvent.UserInputAction();
                double _firstInput = _consoleEvent.UserInputDouble();

                double _secondInput = _consoleEvent.UserInputDouble();

                PerformCalculation(_firstInput, _secondInput, _action);

                _consoleEvent.DisplayUserInputs();

                FinalDecision();


            }
        }
        bool FinalDecision()

        {
            Console.WriteLine("Finished? 'Yes' or 'No'?");
            string _decision = Console.ReadLine();
            _decision.ToLower();
            if (_decision == "yes")
            {
                return false;
            }
            return true;

        }
        public void PerformCalculation(double firstInput, double secondInput, Func<double, double, double> action)
        {
            DisplayCalculation();
            var _result = _calculator.CreateCalculation(firstInput, secondInput, action);
           


        }
        void DisplayCalculation()
        {
            var displayCalc = new DisplayCalculation();
            _calculator._calcEvent.CalculationCompleted += displayCalc.OnCalculation;

        }
        void StoreUserInput()
        {
            _consoleEvent._consoleEvent.UserInput += _consoleEvent.storeUserInput.OnUserInput;
            //_consoleEvent.UserInput += storeUserInput.OnUserInput;
        }
        public void DisplayUserInputs()
        {
            _consoleEvent.storeUserInput.DisplayInputs();
        }


    }
}
