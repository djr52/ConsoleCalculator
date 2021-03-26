using System;
using MyCalculator.EventPublisher;

namespace ConsoleCalculator
{
    public class DisplayCalculation
    {   
        public void OnCalculation(object sender, CalcEventArgs calcEvent)
        {
             Console.WriteLine("Result is: " + calcEvent.Calculation.GetResult());
            
        }
    }

}
