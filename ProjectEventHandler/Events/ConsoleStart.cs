﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventHandler.Events
{
    public class ConsoleStart
    {
        public void OnConsoleMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Welcome to the Console Calculator. Please enter which operation you wish to perform: ");
        }
    }
}
