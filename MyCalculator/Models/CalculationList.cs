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

        public static CalculationList Create(List<double> listOfValues, Func<List<double>, double> operation)
        {
            var _calculation = new CalculationList(listOfValues, operation);
            return _calculation;
        }



        //constructor for 2 param (list, and function)
        public CalculationList(List<double> listOfValues, Func<List<double>, double> calculation)
        {
            ListOfValues = listOfValues;

            //this stores the operation to be performed on A and B
            BulkOperation = calculation;
        }
        public double GetResult()
        {
            return BulkOperation(ListOfValues);
        }
    }
}
