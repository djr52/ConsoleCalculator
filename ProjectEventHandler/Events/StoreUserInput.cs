using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEventHandler.ConsolePublisher;
using System.Linq;

namespace ConsoleEventHandler.Events
{
    public class StoreUserInput
    {
        List<double> userInputs = new List<double>();
        public void OnUserInput(object sender, ConsoleEventArgs consoleEvent)
        {
            userInputs.Add(consoleEvent.UserNumberInput);

        }
        public double DisplayLastInput()
        {
            return userInputs.LastOrDefault();
        }
    }
}
