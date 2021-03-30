using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventHandler.Events
{
    public class ConsoleOptions
    {
        public void OnConsoleMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Select an option by entering its corresponding numbers: " +
                "\n | 1 | Continue Calculations " +
                "\n | 2 | Display Calculation History " +
                "\n | 3 | Exit Calculator");
        }
    }
}
