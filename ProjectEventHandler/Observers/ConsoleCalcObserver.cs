using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEventHandler.Interface;

namespace ConsoleEventHandler.Observers
{
    public class ConsoleCalcObserver : IConsoleObserver
    {
        public void Update(ConsoleEventManager subject)
        {
            
            Console.WriteLine("Calculation Complete. ");
        }
    }
}
