using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventHandler.Events
{
    public class EnterDoubleInput
    {
        public void OnConsoleMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Please enter a number: ");
        }
    }
}
