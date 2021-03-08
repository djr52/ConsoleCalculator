using System;
using MyCalculator.Interfaces;

namespace MyCalculator.EventPublisher
{
    public class CalcEventArgs : EventArgs
    {
        public ICalculation Calculation { get; set; }
    }
}
