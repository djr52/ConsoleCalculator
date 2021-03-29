using System;
using System.Collections.Generic;
using System.Text;
using ConsoleCalculator.Interface;
using ConsoleCalculator.Strategy;

namespace ConsoleCalculator.Factory
{
    public class InputOptionFactory
    {
        private Dictionary<string, IOptionStrategy> _optionMap = new Dictionary<string, IOptionStrategy>();
        public InputOptionFactory()
        {
            _optionMap["1"] = new OptionOne();
            _optionMap["2"] = new OptionTwo();

        }

        public IOptionStrategy getOptionStrategy(string option)
        {
            return _optionMap[option];
        }
    }
}
