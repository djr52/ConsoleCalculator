using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Interfaces;

namespace MyCalculator.Models
{
    public class CalculationList : ICalculation
    {
        //store a bulk operations function

        public Func<List<double>, double> BulkOperation { get; set; }
        //store a list of values for bulk operations
        public List<double> ListOfValues { get; set; }
        public CalculationList() { }
        public static CalculationList Create(List<double> listOfValues, Func<List<double>, double> operation)
        {
            var _calculation = IAbstractCalcFactory.CreateCalcListObj();
            return _calculation.Create(listOfValues, operation);
        }


        //constructor for 2 param (list, and function)
        public CalculationList(List<double> listOfValues, Func<List<double>, double> calculation)
        {
            ListOfValues = listOfValues;

            BulkOperation = calculation;
        }
        public double GetResult()
        {
            return BulkOperation(ListOfValues);
        }
    }
}
