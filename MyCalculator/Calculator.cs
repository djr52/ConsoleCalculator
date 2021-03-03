using System;
using ConsoleCalculator.Models;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Models;
using System.Collections.Generic;
using MyCalculator.Interfaces;
using MyCalculator.Builders;

namespace MyCalculator
{



    public class Calculator
    {
        public CalculatorBuilder _calculatorBuilder = new CalculatorBuilder();

        private ICalculator _calculator;
        public Calculator() { }
        public Calculator(ICalculator calculator)
        {
            this._calculator = calculator;
            
            
        }
        public ICalculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> _operation) //Change the method name to something more like add calculation
        {
            return _calculator.CreateCalculation(listOfValues, _operation);

        }
        public ICalculation CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {

            return _calculator.CreateCalculation(a, b, _operation);

        }

        public void SetCalculator(ICalculator calculator) //Allows replacing object at runtime
        {
            this._calculator = calculator;

        }


    }

}






