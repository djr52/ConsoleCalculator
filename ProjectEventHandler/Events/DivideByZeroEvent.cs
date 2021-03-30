using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventHandler.Events
{
    public class DivideByZeroEvent
    {
        public void OnConsoleMessage(object sender, EventArgs e)
        {
            Console.WriteLine("ERROR: Divided By Zero");
            Console.WriteLine("Skipping Calculation");
        }
    }
}
