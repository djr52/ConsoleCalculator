using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator.ConsolePublisher
{
    public class ConsoleEvent
    {
        public event EventHandler<ConsoleEventArgs> UserInput;
        public void GrabUserInputDouble(double userInput)
        {

            OnUserInput(userInput);
        }
        protected virtual void OnUserInput(double userInput)
        {

            UserInput.Invoke(this, new ConsoleEventArgs() { UserNumberInput = userInput });
        }
        public void GrabUserInputAction(Func<double, double, double> userInput)
        {

            OnUserInput(userInput);
        }
        protected virtual void OnUserInput(Func<double, double, double> userInput)
        {

            UserInput.Invoke(this, new ConsoleEventArgs() { UserActionInput = userInput });
        }

    }
}
