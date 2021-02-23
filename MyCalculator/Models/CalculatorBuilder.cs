using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Interfaces;
using MyCalculator.Models;
using ConsoleCalculator.Models;

namespace MyCalculator.Models
{
    public class CalculatorBuilder : ICalculator
    {
        private ListOfCalculations _listOfCalculations = new ListOfCalculations();


        public ICalculation CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {
            
            var _calculation = Calculation.Create(a, b, _operation);
            _listOfCalculations.AddCalculation(_calculation);
            return _calculation;
        }

        public ICalculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> _operation)
        {
            var _calculation = CalculationList.Create(listOfValues, _operation);
            _listOfCalculations.AddCalculation(_calculation);
            return _calculation;
        }

        public List<ICalculation> GetList()
        {
            var listResult = _listOfCalculations.Calculations;
            return listResult;
        }
    }
}
