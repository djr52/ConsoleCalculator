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
        ConsoleStart consoleStart = new ConsoleStart();
        ConsoleOptions consoleOptions = new ConsoleOptions();
        EnterActionInput consoleAction = new EnterActionInput();
        EnterDoubleInput consoleDouble = new EnterDoubleInput();
        DivideByZeroEvent divideByZero = new DivideByZeroEvent();

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
            _consoleEvent.ConsoleMessage += consoleStart.OnConsoleMessage;
        }
        public void UnregisterConsoleStartEvent()
        {
            _consoleEvent.ConsoleMessage -= consoleStart.OnConsoleMessage;
        }
        public void RegisterConsoleOptionsEvent()
        {
            _consoleEvent.ConsoleMessage += consoleOptions.OnConsoleMessage;
        }
        public void UnregisterConsoleOptionsEvent()
        {
            _consoleEvent.ConsoleMessage -= consoleOptions.OnConsoleMessage;
        }
        public void RegisterConsoleDoubleInput()
        {
            _consoleEvent.ConsoleMessage += consoleDouble.OnConsoleMessage;
        }
        public void UnregisterConsoleDoubleInput()
        {
            _consoleEvent.ConsoleMessage -= consoleDouble.OnConsoleMessage;

        }
        public void RegisterConsoleActionInput()
        {
            _consoleEvent.ConsoleMessage += consoleAction.OnConsoleMessage;
        }
        public void UnregisterConsoleActionInput()
        {
            _consoleEvent.ConsoleMessage -= consoleAction.OnConsoleMessage;

        }
        public void RegisterDivideByZero()
        {
            _consoleEvent.ConsoleMessage += divideByZero.OnConsoleMessage;

        }
        public void UnregisterDivideByZero()
        {
            _consoleEvent.ConsoleMessage -= divideByZero.OnConsoleMessage;

        }
    }
}
