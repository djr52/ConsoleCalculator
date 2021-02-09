using System;
using ConsoleCalculator.Models;
using MyCalculator.CalculatorFunctions;
using System.Collections.Generic;

namespace MyCalculator
{


    public abstract class Calculator
    {


        public List<Calculations> calculations = new List<Calculations>();
        public Calculator() { }

        public Calculator(double a, double b, string operationType)
        {

            CreateCalculation(a, b, operationType);

        }
        public abstract void CreateCalculation(double a, double b, string operationType);

        public void AddCalculation(double a, double b, Func<double, double, double> operation)
        {
            var _calculation = new Calculations(a, b, operation);
            calculations.Add(_calculation);
        }
    }
    public class Sum: Calculator
    {
        public override void CreateCalculation(double a, double b, string operationType)
        {
            Func<double, double, double> _operation;
            _operation = Operations.Sum;
            AddCalculation(a, b, _operation);
        }
    }
    public class Difference : Calculator
    {
        public override void CreateCalculation(double a, double b, string operationType)
        {
            Func<double, double, double> _operation;
            _operation = Operations.Difference;
            AddCalculation(a, b, _operation);
        }
    }
    public class Multiplication : Calculator
    {
        public override void CreateCalculation(double a, double b, string operationType)
        {
            Func<double, double, double> _operation;
            _operation = Operations.Multiplication;
            AddCalculation(a, b, _operation);
        }
    }
    public class Division : Calculator
    {
        public override void CreateCalculation(double a, double b, string operationType)
        {
            Func<double, double, double> _operation;
            _operation = Operations.Division;
            AddCalculation(a, b, _operation);
        }
    }
}
