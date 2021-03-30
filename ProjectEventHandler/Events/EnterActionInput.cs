using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventHandler.Events
{
    public class EnterActionInput
    {
        public void OnConsoleMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Options: ('add', 'sub', 'mul', 'div', 'pow')");
        }
    }
}
