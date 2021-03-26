using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEventHandler.Interface;

namespace ConsoleEventHandler.Observers
{
    public class ConsoleInputObserver : IConsoleObserver
    {
        public void Update(ConsoleEventManager subject)
        {
            var _input = subject.DisplayLastInput();
            Console.WriteLine("User inputted: {0}", _input);
        }
    }
}
