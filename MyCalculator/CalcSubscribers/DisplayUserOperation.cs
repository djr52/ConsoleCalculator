using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.EventPublisher;
using ConsoleCalculator.ConsolePublisher;

namespace MyCalculator.CalcSubscribers
{
    class DisplayUserOperation
    {
        public void OnUserInput(object sender, ConsoleEventArgs consoleEvent)
        {
            Console.WriteLine("Calculation Complete. Result is: " + consoleEvent);
        }
    }
}
