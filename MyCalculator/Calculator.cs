using System;
using ConsoleCalculator.Models;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Models;
using System.Collections.Generic;
using MyCalculator.Interfaces;
using MyCalculator.Builders;
using MyCalculator.EventPublisher;


namespace MyCalculator
{



    public class Calculator
    {
        public CalculatorBuilder _calculatorBuilder = new CalculatorBuilder();
        public CalculatorEvent _calcEvent = new CalculatorEvent();

        private ICalculator _calculator;
        //public CalculatorManager calculatorManager = new CalculatorManager();
        

        public Calculator() { }
        public Calculator(ICalculator calculator)
        {
            this._calculator = calculator;
            
            
        }
        public ICalculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> _operation) //Change the method name to something more like add calculation
        {
            var _calculation = _calculator.CreateCalculation(listOfValues, _operation);
            _calcEvent.GrabCalculation(_calculation);
            return _calculation;
        }
        public ICalculation CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {
            var _calculation = _calculator.CreateCalculation(a, b, _operation);
            _calcEvent.GrabCalculation(_calculation);
            return _calculation;
        }

        public void SetCalculator(ICalculator calculator) //Allows replacing object at runtime
        {
            this._calculator = calculator;
            
        }

    }

}






