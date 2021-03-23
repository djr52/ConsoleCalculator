using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEventHandler.Interface;
using MyCalculator.CalculatorFunctions;

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
                Console.WriteLine("Invalid Operation. Inputs will not be calculated.");
                return DEFAULT_OPERATION;
            }
            return _operationMap[operation];
        }

    }
}
