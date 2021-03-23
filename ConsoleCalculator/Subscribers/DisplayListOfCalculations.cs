using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.EventPublisher;
using MyCalculator.Models;
namespace ConsoleCalculator.Subscribers
{
    public class DisplayListOfCalculations
    {
        public void OnCalculator(object sender, CalculatorEventArgs calcEvent)
        {
            Console.WriteLine("Im supposed to be displaying a list of calculations");
            
            var calcList = calcEvent.Calculator.GetList();
            foreach(var calculation in calcList)
            {
                Console.WriteLine(calculation.GetResult());
            }
            
        }

    }
}
