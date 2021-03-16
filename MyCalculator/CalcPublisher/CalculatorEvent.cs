using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Interfaces;

namespace MyCalculator.EventPublisher
{


    public class CalculatorEvent
    {


        public event EventHandler<CalcEventArgs> CalculationCompleted;
        public void GrabCalculation(ICalculation calculation)
        {
            Console.WriteLine("Grabbing Calculation...");
            OnCalculation(calculation);
        }
        protected virtual void OnCalculation(ICalculation calculation)
        {

            if(CalculationCompleted != null)
                CalculationCompleted.Invoke(this, new CalcEventArgs() { Calculation = calculation });
        }
    }
}
