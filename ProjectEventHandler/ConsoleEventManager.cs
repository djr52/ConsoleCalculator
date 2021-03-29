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
            Console.WriteLine("Please enter a number: ");
            double userInput = UserInputToDouble();

            _eventRegister._consoleEvent.GrabUserInputDouble(userInput);
            this.Notify();
            this.Detach(_inputObserver);
            return userInput;
        }
        public Func<double, double, double> UserInputAction()
        {
            var inputOp = new InputOperationFactory();
            Console.WriteLine("Options: ('add', 'sub', 'mul', 'div', 'pow')");
            string _operation = UserInput();
            var _retrievedOperation = inputOp.getOperationStrategy(_operation).getOperation();

            return _retrievedOperation;


        }

        public void ConsoleStartUp()
        {
            _eventRegister.RegisterConsoleStartEvent();
            _eventRegister._consoleEvent.ConsoleStart();
            _eventRegister.UnregisterConsoleStartEvent();


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
                Console.WriteLine("ERROR: " + e.Message);
                Console.WriteLine("Skipping Calculation");
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
