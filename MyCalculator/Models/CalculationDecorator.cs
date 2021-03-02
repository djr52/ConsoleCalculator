using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Interfaces;
using System.Linq;
using ConsoleCalculator.Models;

namespace MyCalculator.Models
{

    public abstract class CalcComponent : Calculation
    {
        public abstract CalculationList CreateCalculation(List<double> newValues, Func<List<double>, double> operation);

    }


    public class CalculationDecorator : CalcComponent
    {
        //Use decorator for turning single value and inserting into list
        protected double calculation;
        //private ICalculator _calculation;

        public CalculationDecorator(double calculation)
        {
            this.calculation = calculation;
        }

        public override CalculationList CreateCalculation(List<double> newValues, Func<List<double>, double> operation)
        {
            return CalculationList.Create(newValues, operation);
        }

    }
    public class AddValues : CalculationDecorator
    {
        //private ICalculator _calculator;

        public AddValues(double calculation) : base(calculation)
        {

        }
        public override CalculationList CreateCalculation(List<double> newValues, Func<List<double>, double> operation)
        {
            var initialCalc = base.calculation;            
            List<double> _newList = new List<double> { initialCalc};
            _newList.AddRange(newValues);


            return CalculationList.Create(_newList, operation);
        }

    }


}
