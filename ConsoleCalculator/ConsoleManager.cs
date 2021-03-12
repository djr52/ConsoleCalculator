using System;
using ConsoleCalculator.ConsolePublisher;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Builders;
using MyCalculator;

namespace ConsoleCalculator
{
    public class ConsoleManager
    {
        Calculator _calculator = new Calculator(new CalculatorBuilder());
        public ConsoleEvent _consoleEvent = new ConsoleEvent();
        public void Start()
        {
            Console.WriteLine("Welcome to the Console Calculator. Please enter which operation you wish to perform: ");
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
        public double UserInputDouble()
        {
            Console.WriteLine("Please enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

           // _consoleEvent.GrabUserInputDouble(userInput);

            return userInput;
        }
        public Func<double, double, double> UserInputAction()
        {
            Console.WriteLine("Options: ('add', 'sub', 'div', 'mul')");

            string _operation = Console.ReadLine();
            switch (_operation)
            {
                case "add":
                    Func<double, double, double> _action = Operations.Sum;
                    Console.WriteLine("Please enter two numbers for a sum result. ");
                    return _action;
                case "sub":
                    _action = Operations.Difference;
                    Console.WriteLine("Please enter two numbers for a subtracted result. ");
                    return _action;
                case "div":
                    _action = Operations.Division;
                    Console.WriteLine("Please enter two numbers for a divided result. ");
                    return _action;
                case "mul":
                    _action = Operations.Multiplication;
                    Console.WriteLine("Please enter two numbers for a multiplied result. ");
                    return _action;
                default:
                    Console.WriteLine("Invalid operation selected. Defaulted to 0 ");
                    return _action = Operations.Unassigned;


            }
        }
    }
}
