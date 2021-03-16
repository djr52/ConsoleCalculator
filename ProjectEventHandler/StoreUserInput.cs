﻿using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEventHandler.ConsolePublisher;
using System.Linq;

namespace ConsoleEventHandler
{
    public class StoreUserInput
    {
        List<double> userInputs = new List<double>();
        public void OnUserInput(object sender, ConsoleEventArgs consoleEvent)
        {
            userInputs.Add(consoleEvent.UserNumberInput);
            Console.WriteLine("First input: " + userInputs[0]);

        }
        public void DisplayInputs()
        {
            userInputs.Remove(userInputs.Last());
            foreach(double numbers in userInputs)
            {
                Console.WriteLine(numbers + " ");
            }
        }
    }
}