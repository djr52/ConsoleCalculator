using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Interfaces;

namespace MyCalculator.EventPublisher
{


    public class CalculatorEvent
    {


        public event EventHandler<CalcEventArgs> CalculationCompleted; //To pass in custom event data, such as the calculator object, please create a calculator event arg class that extends EventArgs
        public void GrabCalculation(ICalculation calculation)
        {
            
            OnCalculation(calculation);
        }
        protected virtual void OnCalculation(ICalculation calculation)
        {
            CalculationCompleted.Invoke(this, new CalcEventArgs() { Calculation = calculation });
        }
    }
}
