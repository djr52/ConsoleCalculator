using System;
using System.Collections.Generic;
using System.Text;


namespace MyCalculator.CalculatorFunctions
{
    class ExponentialOperations
    {
        public static Func<double, double> Square = (a) => a * a;
        public static Func<double, double> SquareRoot = (a) => Math.Pow(a, 0.5);
        public static Func<double, double> Unassigned = (a) => 0;

    }
}
