using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventHandler.ConsolePublisher
{
    public class ConsoleEvent
    {
        public event EventHandler<ConsoleEventArgs> UserInput;
        public event EventHandler ConsoleMessage;

        public void GrabUserCommandInput(string userInput)
        {
            OnUserInput(userInput);
        }
        protected virtual void OnUserInput(string userInput)
        {
            if (UserInput != null)
                UserInput(this, new ConsoleEventArgs() { UserCommandInput = userInput });
        }

        public void GrabUserInputDouble(double userInput)
        {
            OnUserInput(userInput);
        }
        protected virtual void OnUserInput(double userInput)
        {

            if(UserInput != null) 
                UserInput(this, new ConsoleEventArgs() { UserNumberInput = userInput });
        }
        public void GrabUserInputAction(Func<double, double, double> userInput)
        {

            OnUserInput(userInput);
        }
        protected virtual void OnUserInput(Func<double, double, double> userInput)
        {

            if (UserInput != null)
                UserInput(this, new ConsoleEventArgs() { UserActionInput = userInput });
        }
        public void ConsoleStart()
        {
            OnConsoleStartUp();
        }
        protected virtual void OnConsoleStartUp()
        {
            if (ConsoleMessage != null)
                ConsoleMessage(this, EventArgs.Empty);
        }
    }
}
