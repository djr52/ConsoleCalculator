using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Interfaces;
using MyCalculator.Models;
using ConsoleCalculator.Models;
using MyCalculator.EventPublisher;

namespace MyCalculator.Builders
{
    public class CalculatorBuilder : ICalculator
    {
        private ListOfCalculations _listOfCalculations = new ListOfCalculations();
        public CalculatorEvent _calcEvent = new CalculatorEvent();
        CalculatorBuilder calculatorBuilder;


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
