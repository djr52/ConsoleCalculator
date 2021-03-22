using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.CalculatorFunctions;
using ConsoleEventHandler.Factories;
using ConsoleEventHandler.Interface;
using ConsoleEventHandler.ConsolePublisher;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;



namespace ConsoleEventHandler
{

    public class ConsoleEventManager
    {
        private readonly ILogger _logger;
        public ConsoleEvent _consoleEvent = new ConsoleEvent();
        public StoreUserInput storeUserInput = new StoreUserInput();

        public ConsoleEventManager() { }

        ConsoleEventManager(ILogger<ConsoleEventManager> logger)
        {
            this._logger = logger;
        }

        public void DivideByZeroError()
        {
            Console.WriteLine("Error");
            _logger.LogInformation("Can't divide by zero, skipping calculation");
        }

        void StoreUserInput()
        {

            _consoleEvent.UserInput += storeUserInput.OnUserInput;
        }
        public void DisplayUserInputs()
        {
            storeUserInput.DisplayInputs();
        }
        public double UserInputDouble()
        {
            StoreUserInput();
            Console.WriteLine("Please enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            _consoleEvent.GrabUserInputDouble(userInput);

            return userInput;
        }
        public Func<double, double, double> UserInputAction()
        {
            var inputOp = new InputOperationFactory();
            
            string _operation = Console.ReadLine();
            var _retrievedOperation = inputOp.getOperationStrategy(_operation).getOperation();

            return _retrievedOperation;


        }


    }
}
