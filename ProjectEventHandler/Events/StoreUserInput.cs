using System;
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

        }
        public void DisplayInputs()
        {
            foreach(double numbers in userInputs)
            {
                Console.WriteLine(numbers + " ");
            }
        }
    }
}
