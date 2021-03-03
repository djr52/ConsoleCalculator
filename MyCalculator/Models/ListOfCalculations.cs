using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Interfaces;
using System.Linq;

namespace MyCalculator.Models
{
    public class ListOfCalculations
    {
        public List<ICalculation> Calculations = new List<ICalculation>();

        public void AddCalculation(ICalculation calculations)
        {
            this.Calculations.Add(calculations); 
        }
        public ICalculation GetFirstCalculation()
        {
            var _firstElement = Calculations.FirstOrDefault();
            return _firstElement;
            
        }
        public ICalculation GetLastCalculation()
        {
            var _lastElement = Calculations.LastOrDefault();
            return _lastElement;
        }
    }
}

