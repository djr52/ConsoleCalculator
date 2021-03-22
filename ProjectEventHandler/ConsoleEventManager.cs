using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.CalculatorFunctions;
using ConsoleEventHandler.Factories;
using ConsoleEventHandler.Interface;

using ConsoleEventHandler.ConsolePublisher;
namespace ConsoleEventHandler
{

    public class ConsoleEventManager
    {
        public ConsoleEvent _consoleEvent = new ConsoleEvent();
        public StoreUserInput storeUserInput = new StoreUserInput();
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
