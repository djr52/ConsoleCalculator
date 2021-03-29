using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventHandler.Events
{
    public class ConsoleOptions
    {
        public void OnConsoleOptions(object sender, EventArgs e)
        {
            Console.WriteLine("Select an option by entering its corresponding numbers: " +
                "\n | 1 | Display History of Calculations " +
                "\n | 2 | Exit Calculator");
        }
    }
}
