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
        public CalculatorBuilder _calculatorBuilder = new CalculatorBuilder();

        public Calculator() { }
        public Calculator(List<double> listOfValues, Func<List<double>, double> _operation)
        {
            _calculatorBuilder.CreateCalculation(listOfValues, _operation);
            
            //CreateCalculation(listOfValues, _operation);

        }
        public Calculator(double a, double b, Func<double, double, double> _operation)
        {

            _calculatorBuilder.CreateCalculation(a, b, _operation);

        }



    }

}






