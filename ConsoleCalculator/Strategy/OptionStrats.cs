using System;
using System.Collections.Generic;
using System.Text;
using ConsoleCalculator.Interface;
using ConsoleCalculator.RegisterEvents;
namespace ConsoleCalculator.Strategy
{
    //2 - 3 options (view calculation history, continue calculations(if not exit program), and potentially delete calc history)
    public class OptionOne : IOptionStrategy
    {
        public EventRegister _eventRegister;
        public ConsoleManager consoleManager = new ConsoleManager();
        public void getOption()
        {
            consoleManager.GetCalculationList();
        }
    }

    public class OptionTwo : IOptionStrategy
    {
        public void getOption()
        {
            Environment.Exit(0);
        }
    }
}
