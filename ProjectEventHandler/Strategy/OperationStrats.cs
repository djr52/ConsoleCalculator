using System;
using System.Collections.Generic;
using System.Text;
using ConsoleEventHandler.Interface;
using MyCalculator.CalculatorFunctions;

namespace ConsoleEventHandler.Strategy
{
    public class OperationSum : OperationStrategy
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Sum;

        }
    }
    class OperationDifference : OperationStrategy
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Difference;

        }
    }
    class OperationMultiply : OperationStrategy
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Multiplication;

        }
    }
    class OperationDivide : OperationStrategy
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Division;

        }
    }
    class OperationPower : OperationStrategy
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.PowerOf;

        }
    }
    class DefaultOperation : OperationStrategy
    {
        public Func<double, double, double> getOperation()
        {
            return Operations.Unassigned;

        }
    }
}
