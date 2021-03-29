using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEventHandler.Interface;
using MyCalculator.CalculatorFunctions;
using ConsoleEventHandler.Strategy;

namespace ConsoleEventHandler.Factories
{
    public class InputOperationFactory
    {
        private Dictionary<string, OperationStrategy> _operationMap = new Dictionary<string, OperationStrategy>();
        private Dictionary<string, OptionStrategy> _optionMap = new Dictionary<string, OptionStrategy>();
        private OperationStrategy DEFAULT_OPERATION = new DefaultOperation();
        
        public InputOperationFactory()
        {
            _operationMap["add"] = new OperationSum();
            _operationMap["sub"] = new OperationDifference();
            _operationMap["mul"] = new OperationMultiply();
            _operationMap["div"] = new OperationDivide();
            _operationMap["pow"] = new OperationPower();

            _optionMap["1"] = new OptionOne();

        }
        public OperationStrategy getOperationStrategy(string operation)
        {
            if (!_operationMap.ContainsKey(operation))
            {
                getDefaultStrategy();
            }
            return _operationMap[operation];
        }
        public OptionStrategy getOptionStrategy(string option)
        {
            return _optionMap[option];
        }
        private OperationStrategy getDefaultStrategy()
        {
                return DEFAULT_OPERATION;
        }

    }
}
