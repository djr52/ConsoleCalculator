using System;
using System.Collections.Generic;
using System.Text;

using ProjectEventHandler.ConsolePublisher;
namespace ProjectEventHandler
{
    /*
    public interface IEventHandler
    {
        EventArgs GetEventData();
        
    }
    class ConsoleEventManager
    {
        Program main = new Program();
        
    }
    */
    public class ConsoleEventManager
    {
        public ConsoleEvent _consoleEvent = new ConsoleEvent();
        public StoreUserInput storeUserInput = new StoreUserInput();
        public void Start()
        {
            Console.WriteLine("Welcome to the Console Calculator. Please enter which operation you wish to perform: ");
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


    }
}
