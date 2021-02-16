using System;
using ConsoleCalculator.Models;
using MyCalculator.CalculatorFunctions;
using System.Collections.Generic;

namespace MyCalculator
{

    public class Calculator : ICreateCalculation
    {

        public List<Calculations> Calculations = new List<Calculations>();
        CreateCalculations _calculation = new CreateCalculations();
        public Calculator() { }


        public Calculator(double a, double b, Func<double, double, double> operation)
        {

            CreateCalculation(a, b, operation);

        }
        public Calculations CreateCalculation(double a, double b, Func<double, double, double> operation)
        {

            var _result = _calculation.CreateCalculation(a, b, operation);

            Calculations.Add(_result);

            return _result;
        }

    }    
    interface ICreateCalculation
    {
        Calculations CreateCalculation(double a, double b, Func<double,double,double>operation);
    }
    public class CreateCalculations : ICreateCalculation
    {

        public Calculations CreateCalculation(double a, double b, Func<double, double, double> operation)
        {
            var _calculation = new Calculations(a, b, operation);
            return _calculation;


        }
    }


}
