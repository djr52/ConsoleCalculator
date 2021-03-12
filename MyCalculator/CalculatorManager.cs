using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.CalcSubscribers;
using ConsoleCalculator;
using ConsoleCalculator.ConsolePublisher;
namespace MyCalculator
{
    public class CalculatorManager
    {
        
        public ConsoleManager _consoleManager = new ConsoleManager();        
        public void DisplayUserInput()
        {
            var displayInput = new DisplayUserOperation();
            _consoleManager._consoleEvent.UserInput += displayInput.OnUserInput;
        }
    }
}
