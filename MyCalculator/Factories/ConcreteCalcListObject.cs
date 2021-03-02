using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Interfaces;
using MyCalculator.Models;

namespace MyCalculator.Factories
{
    class ConcreteCalcListObj : IAbstractCalcListObj
    {
        public static CalculationList Create(List<double> listOfValues, Func<List<double>, double> operation)
        {
            return new CalculationList(listOfValues, operation);
        }
        CalculationList IAbstractCalcListObj.Create(List<double> listOfValues, Func<List<double>, double> operation)
        {
            return ConcreteCalcListObj.Create(listOfValues, operation);
        }

    }
}
