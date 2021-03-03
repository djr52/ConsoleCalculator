using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.Interfaces;
using ConsoleCalculator.Models;

namespace MyCalculator.Factories
{
    class ConcreteCalcObject : IAbstractCalcObject
    {
        public static Calculation Create(double a, double b, Func<double, double, double> operation)
        {
            return new Calculation(a, b, operation);

        }
        Calculation IAbstractCalcObject.Create(double a, double b, Func<double, double, double> operation)
        {
            return ConcreteCalcObject.Create(a, b, operation);
        }

    }
}
