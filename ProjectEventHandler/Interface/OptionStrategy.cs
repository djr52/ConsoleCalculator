using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventHandler.Interface
{
    public interface OptionStrategy
    {
        public void getOption();
    }

    //2 - 3 options (view calculation history, continue calculations(if not exit program), and potentially delete calc history)
    public class OptionOne : OptionStrategy
    {
        public void getOption()
        {
            Environment.Exit(0);
        }
    }
}
