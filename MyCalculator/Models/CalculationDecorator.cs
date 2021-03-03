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
        public abstract CalculationList CreateNewCalculation(List<double> newValues, Func<List<double>, double> operation);

    }


    public class CalculationDecorator : CalcComponent
    {
        //Use decorator for turning single value and inserting into list
        protected double calculationResult;
        //protected Calculation calculation

        public CalculationDecorator(double calculationResult) //or Calculator calculation
        {
            this.calculationResult = calculationResult;
        }

        public override CalculationList CreateNewCalculation(List<double> newValues, Func<List<double>, double> operation)
        {
            return CalculationList.Create(newValues, operation);
        }

    }
    public class AddValues : CalculationDecorator
    {
        //private ICalculator _calculator;

        public AddValues(double calculationResult) : base(calculationResult)
        {

        }
        public override CalculationList CreateNewCalculation(List<double> newValues, Func<List<double>, double> operation)
        {
            var initialCalc = base.calculationResult;            
            List<double> _newList = new List<double> { initialCalc};
            _newList.AddRange(newValues);


            return CalculationList.Create(_newList, operation);
        }





        /*

        public AddValues(Calculation calculation) : base(calculation)
        {

        }
        public override CalculationList CreateCalculation(List<double> newValues, Func<List<double>, double> operation) //Taking type Calculator will use the original two values
                                                                                                                          (before original calculation) for calculation the new list
        {
            var initialCalc = base.CreateCalculation(newValues, operation);
            List<double> _newList = new List<double> { initialCalc };
            _newList.AddRange(newValues);


            return CalculationList.Create(_newList, operation);
        }
        */

    }


}
