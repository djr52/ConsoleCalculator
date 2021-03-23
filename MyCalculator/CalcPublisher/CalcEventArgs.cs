using System;
using MyCalculator.Interfaces;
using MyCalculator.Builders;
//using MyCalculator.Models;

namespace MyCalculator.EventPublisher
{
    public class CalcEventArgs : EventArgs
    {
        public ICalculation Calculation { get; set; }
        //public Calculator Calculator { get; set; }
    }
    public class CalculatorEventArgs : EventArgs
    {
        public CalculatorBuilder Calculator { get; set; }

    }
}
