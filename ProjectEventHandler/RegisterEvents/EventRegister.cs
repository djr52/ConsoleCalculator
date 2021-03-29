using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEventHandler.ConsolePublisher;
using ConsoleEventHandler.Events;

namespace ConsoleEventHandler.RegisterEvents
{
    

    public class EventRegister
    {
        public ConsoleEvent _consoleEvent = new ConsoleEvent();
        public StoreUserInput storeUserInput = new StoreUserInput();
        public ConsoleStart consoleStart = new ConsoleStart();
        public ConsoleOptions consoleOptions = new ConsoleOptions();
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
        public void UnregisterConsoleStartEvent()
        {
            _consoleEvent.ConsoleMessage -= consoleStart.OnConsoleStart;
        }
        public void RegisterConsoleOptionsEvent()
        {
            _consoleEvent.ConsoleMessage += consoleOptions.OnConsoleOptions;
        }
        public void UnregisterConsoleOptionsEvent()
        {
            _consoleEvent.ConsoleMessage -= consoleOptions.OnConsoleOptions;
        }
    }
}
