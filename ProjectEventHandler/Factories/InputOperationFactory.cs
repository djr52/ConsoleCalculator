using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEventHandler.Interface;
using MyCalculator.CalculatorFunctions;

namespace ConsoleEventHandler.Factories
{
    public class InputOperationFactory
    {
        Dictionary<string, OperationStrategy> _operationMap = new Dictionary<string, OperationStrategy>();
        public InputOperationFactory()
        {
            _operationMap["add"] = new OperationSum();
            _operationMap["sub"] = new OperationDifference();
            _operationMap["mul"] = new OperationMultiply();
            _operationMap["div"] = new OperationDivide();

        }
        public OperationStrategy getOperationStrategy(string operation)
        {
            return _operationMap[operation];
        }

    }
}
