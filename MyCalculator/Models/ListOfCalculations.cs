using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Interfaces;

namespace MyCalculator.Models
{
    class ListOfCalculations
    {
        public List<ICalculation> Calculations = new List<ICalculation>();

        public void AddCalculation(ICalculation calculations)
        {
            this.Calculations.Add(calculations); 
        }
    }
}

