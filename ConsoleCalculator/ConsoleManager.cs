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
        ConsoleEventManager _consoleEventMan = new ConsoleEventManager();
        public void Start()
        {
            Console.WriteLine("Welcome to the Console Calculator. Please enter which operation you wish to perform: ");
            Console.WriteLine("Options: ('add', 'sub', 'div', 'mul')");
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
            _consoleEventMan._consoleEvent.UserInput += _consoleEventMan.storeUserInput.OnUserInput;
            //_consoleEvent.UserInput += storeUserInput.OnUserInput;
        }
        public void DisplayUserInputs()
        {
            _consoleEventMan.storeUserInput.DisplayInputs();
        }


    }
}
