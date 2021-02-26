using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Models;
using MyCalculator;
using ConsoleCalculator.Models;

namespace MyCalculator.Interfaces
{
    public interface AbstractCalculatorFactory
    {
        public IAbstractCalc CreateCalcObject(double a, double b, Func<double, double, double> _operation);
        public AbstractCalcList CreateCalcListObject();

    }


    class ConcreteCalculatorFactory : AbstractCalculatorFactory
    {
        public IAbstractCalc CreateCalcObject(double a, double b, Func<double, double, double> _operation)
        {
            return new ConcreteCalculator();
        } 
        public AbstractCalcList CreateCalcListObject()
        {
            return new ConcreteCalculatorList();
        }
    }

    public class ConcreteCalculator : IAbstractCalc
    {
        public ICalculation CreateCalcObject(double a, double b, Func<double, double, double> _operation)
        {
            var _calculation = Calculation.Create(a, b, _operation);
            return _calculation;
            //return "Test";
        }

    }
    public interface IAbstractCalc
    {

    }

    public interface AbstractCalcList
    {
        public string Create(List<double> listOfValues, Func<List<double>, double> operation);
    }
    class ConcreteCalculatorList : AbstractCalcList
    {
        public string Create(List<double> listOfValues, Func<List<double>, double> operation)
        {
            return "Test";
        }
    }





}
