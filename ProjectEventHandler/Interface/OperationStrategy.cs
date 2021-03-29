using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.CalculatorFunctions;

namespace ConsoleEventHandler.Interface
{
    public interface OperationStrategy
    {
        public Func<double, double, double> getOperation();
    }
    
}
