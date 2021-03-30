using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Builders;
using ConsoleEventHandler.Factories;
using ConsoleEventHandler.Interface;
using ConsoleEventHandler.ConsolePublisher;
using ConsoleEventHandler.Observers;
using ConsoleEventHandler.RegisterEvents;


namespace ConsoleEventHandler
{

    public class ConsoleEventManager : IConsoleSubject
    {
        public EventRegister _eventRegister = new EventRegister();
        public ConsoleInputObserver _inputObserver = new ConsoleInputObserver();
        InputOperationFactory _inputOp = new InputOperationFactory();
        private List<IConsoleObserver> _observers;

        public ConsoleEventManager() 
        {
            _observers = new List<IConsoleObserver>();
        }
        public void Attach(IConsoleObserver observer)
        {
            _observers.Add(observer);
        }
        public void Detach(IConsoleObserver observer)
        {
            _observers.Remove(observer);
            
        }
        public void Notify()
        {
            _observers.ForEach(o =>
            {
                o.Update(this);
            });
        }

        public double DisplayLastInput()
        {
            return _eventRegister.storeUserInput.DisplayLastInput();
        }

        public double UserInputDouble()
        {
            this.Attach(_inputObserver);
            _eventRegister.RegisterStoreUserInputEvent();
            ConsoleDoubleInput();
            double userInput = UserInputToDouble();

            _eventRegister._consoleEvent.GrabUserInputDouble(userInput);
            this.Notify();
            this.Detach(_inputObserver);
            return userInput;
        }
        public Func<double, double, double> UserInputAction()
        {
            ConsoleActionInput();
            string _operation = UserInput();
            var _retrievedOperation = _inputOp.getOperationStrategy(_operation).getOperation();
            return _retrievedOperation;

        }

        public void ConsoleStartUp()
        {
            _eventRegister.RegisterConsoleStartEvent();
            _eventRegister._consoleEvent.WriteConsoleMessage();
            _eventRegister.UnregisterConsoleStartEvent();

        }
        void ConsoleDoubleInput()
        {
            _eventRegister.RegisterConsoleDoubleInput();
            _eventRegister._consoleEvent.WriteConsoleMessage();
            _eventRegister.UnregisterConsoleDoubleInput();
        }
        void ConsoleActionInput()
        {
            _eventRegister.RegisterConsoleActionInput();
            _eventRegister._consoleEvent.WriteConsoleMessage();
            _eventRegister.UnregisterConsoleActionInput();
        }
        void ConsoleDivideByZero()
        {
            _eventRegister.RegisterDivideByZero();
            _eventRegister._consoleEvent.WriteConsoleMessage();
            _eventRegister.UnregisterDivideByZero();
        }
        public void DivideByZeroException(Func<double, double, double> action, double secondInput)
        {
            try
            {
                if(action == Operations.Division && secondInput == 0)
                {
                    throw new DivideByZeroException();
                }
            }
            catch(DivideByZeroException e)
            {
                ConsoleDivideByZero();
            }
        }

        double UserInputToDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        string UserInput()
        {
            return Console.ReadLine();
        }
    }
}
