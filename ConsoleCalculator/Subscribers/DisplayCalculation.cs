using System;
using MyCalculator.EventPublisher;
namespace ConsoleCalculator
{
    public class DisplayCalculation
    {
        public void OnCalculation(object sender, CalcEventArgs args)
        {
            Console.WriteLine("Calculation Complete. Result is: " + args.Calculation.GetResult());
        }
    }

}
