using System;
using MyCalculator;
using MyCalculator.Builders;
using MyCalculator.CalculatorFunctions;
using MyCalculator.EventPublisher;
namespace ConsoleCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            var builtCalculator = new CalculatorBuilder();
            Calculator _calculator = new Calculator(builtCalculator);


            var calcEvent = new CalculatorEvent();
            var displayCalc = new DisplayCalculation();




            Console.WriteLine("Please enter two numbers for a sum result. ");
            Func<double, double, double> _action = Operations.Sum;

            double _firstInput = UserInputDouble();
            double _secondInput = UserInputDouble();

            var _result = _calculator.CreateCalculation(_firstInput, _secondInput, _action);
            
            calcEvent.CalculationCompleted += displayCalc.OnCalculation;
            calcEvent.GrabCalculation(_result);

        }
        static double UserInputDouble()
        {
            Console.WriteLine("Hello! Please enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());
            return userInput;
        }


    }

}
