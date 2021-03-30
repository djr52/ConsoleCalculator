using System;
using System.Collections.Generic;
using System.Text;
using ConsoleCalculator.Interface;
using ConsoleCalculator.RegisterEvents;
namespace ConsoleCalculator.Strategy
{

    public class OptionOne : IOptionStrategy
    {        
        public void getOption()
        {
            
        }
    }

    public class OptionTwo : IOptionStrategy
    {
        public ConsoleManager consoleManager = new ConsoleManager();
        public void getOption()
        {
            consoleManager.GetCalculationList();
        }
    }
    public class OptionThree : IOptionStrategy
    {
        public void getOption()
        {
            Environment.Exit(0);
        }
    }
}
