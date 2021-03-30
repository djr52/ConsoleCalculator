using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.EventPublisher;
using MyCalculator.Models;
using System.Linq;
namespace ConsoleCalculator.Subscribers
{
    public class DisplayListOfCalculations
    {
        //List<double> localCalcList;
        public void OnCalculator(object sender, CalculatorEventArgs calcEvent)
        {
            Console.WriteLine("Displaying a list of calculations.");
            
            var calcList = calcEvent.Calculator.GetList();
            foreach(var calculation in calcList)
            {
                Console.WriteLine(calculation.GetResult());
                //localCalcList.Add(calculation.GetResult());
            }
            
        }
        /*
        public double DisplayLastCalculation()
        {
            return localCalcList.LastOrDefault();
        }
        */

    }
}
