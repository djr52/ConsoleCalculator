using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEventHandler.ConsolePublisher;

namespace ConsoleEventHandler.RegisterEvents
{
    

    public class EventRegister
    {
        public ConsoleEvent _consoleEvent = new ConsoleEvent();
        public StoreUserInput storeUserInput = new StoreUserInput();
        public ConsoleStart consoleStart = new ConsoleStart();
        public void RegisterStoreUserInputEvent()
        {

            _consoleEvent.UserInput += storeUserInput.OnUserInput;
        }


        public void UnregisterStoreUserInputEvent()
        {

            _consoleEvent.UserInput -= storeUserInput.OnUserInput;
        }
        public void RegisterConsoleStartEvent()
        {
            _consoleEvent.ConsoleMessage += consoleStart.OnConsoleStart;
        }
    }
}
