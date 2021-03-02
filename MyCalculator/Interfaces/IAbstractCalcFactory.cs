using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Models;
using ConsoleCalculator.Models;

namespace MyCalculator.Interfaces
{
    interface IAbstractCalcFactory
    {        
        IAbstractCalc CreateCalcObject();
        IAbstractCalcList CreateCalcListObject();

    }
    class ConcreteFactory : IAbstractCalcFactory
    {
        public IAbstractCalc CreateCalcObject()
        {
            return new ConcreteCalcObject();
        }
        public IAbstractCalcList CreateCalcListObject()
        {
            return new ConcreteCalcListObject();
        }
    }

    public interface IAbstractCalc
    {
        //static Calculation Create() => new Calculation();
        Calculation Create(double a, double b, Func<double, double, double> operation);

    }
    public interface IAbstractCalcList
    {
        CalculationList Create();
    }

    class ConcreteCalcObject : IAbstractCalc
    {
        public static Calculation Create(double a, double b, Func<double, double, double> operation)
        {
            return new Calculation(a, b, operation);
        }
        Calculation IAbstractCalc.Create(double a, double b, Func<double, double, double> operation)
        {
            return ConcreteCalcObject.Create(a, b, operation);
        }
        

    }
    class ConcreteCalcListObject : IAbstractCalcList
    {
        public static CalculationList Create()
        {
            return new CalculationList();
        }
        CalculationList IAbstractCalcList.Create()
        {
            return ConcreteCalcListObject.Create();
        }


    }
}
