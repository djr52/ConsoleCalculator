using System;
using ConsoleCalculator.Models;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Models;
using System.Collections.Generic;
using MyCalculator.Interfaces;


namespace MyCalculator
{

    public class Calculator
    {
        public List<ICalculation> Calculations = new List<ICalculation>();



        //Calculator Constructor - A constructor is automaticly called when a class is instantiated

        public Calculator() { }
        public Calculator(List<double> listOfValues, Func<List<double>, double> _operation)
        {

            CreateCalculation(listOfValues, _operation);

        }
        public Calculator(double a, double b, Func<double, double, double> _operation)
        {

            CreateCalculation(a, b, _operation);

        }
        public ICalculation CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {
           

            var _calculation = Calculation.Create(a, b, _operation);
            addCalculation(_calculation);

            return _calculation;

        }
        public ICalculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> operation)
        {
            
            var _calculation = CalculationList.Create(listOfValues, operation);
            addCalculation(_calculation);

            return _calculation;

        }

        public void addCalculation(ICalculation calculation)
        {
            Calculations.Add(calculation);

        }


    }
    public class ListofCalculation
    {
        public List<ICalculation> Calculations = new List<ICalculation>();

        public void AddCalculation(ICalculation calculations)
        {

        }
    }
}






