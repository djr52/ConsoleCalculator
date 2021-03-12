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
            ConsoleManager console = new ConsoleManager();
            console.Start();

            //var calcEvent = new CalculatorEvent(); //Publisher from  calculator
            //Setup publisher and subscriber seperate from the Main program, integrate with actual methods
            //var displayCalc = new DisplayCalculation(); //Have subscriber be moved to the calculator class

            Func<double, double, double> _action = console.UserInputAction();
            double _firstInput = console.UserInputDouble();
            double _secondInput = console.UserInputDouble();

            console.PerformCalculation(_firstInput, _secondInput, _action);

            
        }

    }

}
