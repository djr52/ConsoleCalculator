using System;
using MyCalculator.EventPublisher;

namespace ConsoleCalculator
{
    public class DisplayCalculation
    {   
        public void OnCalculation(object sender, CalcEventArgs calcEvent)
        {
            Console.WriteLine("Calculation Complete. Result is: " + calcEvent.Calculation.GetResult());
        }
    }

}
