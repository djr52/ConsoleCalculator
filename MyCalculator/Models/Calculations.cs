using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.CalculatorFunctions;

namespace ConsoleCalculator.Models
{
    public class Calculations
    {
        public double A { get; set; }
        public double B { get; set; }
        public Func<double, double, double> Operation { get; set; }
        public Calculations(double a, double b, Func<double, double, double> calculations)
        {
            A = a;
            B = b;
            Operation = calculations;
        }
        public double GetResults()
        {
            return Operation(A, B);
        }
    }
}
