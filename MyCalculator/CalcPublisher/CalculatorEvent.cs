using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Interfaces;
using MyCalculator.Builders;

namespace MyCalculator.EventPublisher
{


    public class CalculatorEvent
    {


        public event EventHandler<CalcEventArgs> CalculationCompleted;
        public event EventHandler<CalculatorEventArgs> UsingCalculator;

        public void GrabCalculation(ICalculation calculation)
        {
            Console.WriteLine("Grabbing Calculation...");
            OnCalculation(calculation);
        }
        public void UseCalculator(CalculatorBuilder calculator)
        {
            Console.WriteLine("Using Calculator...");
            OnCalculator(calculator);
        }
        protected virtual void OnCalculation(ICalculation calculation)
        {

            if(CalculationCompleted != null)
                CalculationCompleted(this, new CalcEventArgs() { Calculation = calculation });
        }
        protected virtual void OnCalculator(CalculatorBuilder calculator)
        {
            if (UsingCalculator != null)
                UsingCalculator(this, new CalculatorEventArgs() { Calculator = calculator });
        }
    }
}
