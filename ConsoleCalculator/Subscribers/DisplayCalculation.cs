using System;
using MyCalculator.EventPublisher;
namespace ConsoleCalculator
{
    public class DisplayCalculation
    {
        //public CalculatorEvent _calcEvent = new CalculatorEvent();
   
        public void OnCalculation(object sender, CalcEventArgs calcEvent)
        {
            Console.WriteLine("Calculation Complete. Result is: " + calcEvent.Calculation.GetResult());
        }
    }

}
