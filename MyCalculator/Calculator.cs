using System;
using ConsoleCalculator.Models;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Models;
using System.Collections.Generic;
using MyCalculator.Interfaces;


namespace MyCalculator
{



    public class CalculatorBuilder : ICalculator
    {
        private ListofCalculations listOfCalculations = new ListofCalculations();
        

        public ICalculation CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {
            var _calculation = Calculation.Create(a, b, _operation);
            listOfCalculations.AddCalculation(_calculation);
            return _calculation;
        }
        public ICalculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> _operation)
        {
            var _calculation = CalculationList.Create(listOfValues, _operation);
            listOfCalculations.AddCalculation(_calculation);
            //listOfCalculations.Calculations[0].GetResult();
            return _calculation;
        }
        public List<ICalculation> GetList()
        {
            var listResult = listOfCalculations.Calculations;
            return listResult;
        }
        

    }




    public class Calculator
    {
        //public List<ICalculation> Calculations = new List<ICalculation>();
        public CalculatorBuilder calculatorBuilder = new CalculatorBuilder();

 //Consolidate these 2 overloaded methods by passing in one interfaceable object value (Builder??)

        public Calculator() { }
        public Calculator(List<double> listOfValues, Func<List<double>, double> _operation)
        {
            calculatorBuilder.CreateCalculation(listOfValues, _operation);
            //CreateCalculation(listOfValues, _operation);

        }
        public Calculator(double a, double b, Func<double, double, double> _operation)
        {

            calculatorBuilder.CreateCalculation(a, b, _operation);

        }



    }
    public class ListofCalculations
    {
        public List<ICalculation> Calculations = new List<ICalculation>();

        public void AddCalculation(ICalculation calculations)
        {
            this.Calculations.Add(calculations);
        }
    }
}






