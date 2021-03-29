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
        private OperationStrategy DEFAULT_OPERATION = new DefaultOperation();
        
        public InputOperationFactory()
        {
            _operationMap["add"] = new OperationSum();
            _operationMap["sub"] = new OperationDifference();
            _operationMap["mul"] = new OperationMultiply();
            _operationMap["div"] = new OperationDivide();
            _operationMap["pow"] = new OperationPower();

        }
        public OperationStrategy getOperationStrategy(string operation)
        {
            if (!_operationMap.ContainsKey(operation))
            {
                getDefaultStrategy();
            }
            return _operationMap[operation];
        }

        private OperationStrategy getDefaultStrategy()
        {
                return DEFAULT_OPERATION;
        }

    }
}
