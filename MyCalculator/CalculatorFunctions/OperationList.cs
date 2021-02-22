using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyCalculator.CalculatorFunctions
{
    class OperationList
    {
        public static Func<List<double>, double> SumList = (a) => a.Sum();
        public static Func<List<double>, double> Unassigned = (a) => 0;
    }
}
