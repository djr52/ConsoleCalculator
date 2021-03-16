using System;
//using MyCalculator.EventPublisher;
using ConsoleEventHandler;
namespace ConsoleCalculator
{
    public class Program
    {

        static void Main(string[] args)
        {
            ConsoleManager console = new ConsoleManager();
            ConsoleEventManager consoleEvent = new ConsoleEventManager();
            console.Start();

            Func<double, double, double> _action = console.UserInputAction();
            double _firstInput = consoleEvent.UserInputDouble();
        
            double _secondInput = consoleEvent.UserInputDouble();

            console.PerformCalculation(_firstInput, _secondInput, _action);

            consoleEvent.DisplayUserInputs();

        }


    }

}
