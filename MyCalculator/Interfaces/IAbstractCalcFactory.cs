using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Models;
using ConsoleCalculator.Models;
using MyCalculator.Factories;

namespace MyCalculator.Interfaces
{
    public interface IAbstractCalcFactory
    {        
        static IAbstractCalcObject CreateCalcObject() => new ConcreteCalcObject();
        static IAbstractCalcListObj CreateCalcListObj() => new ConcreteCalcListObj();

    }


    public interface IAbstractCalcObject
    {
        Calculation Create(double a, double b, Func<double, double, double> operation);

    }
    
    public interface IAbstractCalcListObj
    {
        CalculationList Create(List<double> listOfValues, Func<List<double>, double> operation);
    }

}
