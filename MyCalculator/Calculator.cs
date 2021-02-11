using System;
using ConsoleCalculator.Models;
using MyCalculator.CalculatorFunctions;
using System.Collections.Generic;

namespace MyCalculator
{

    public class Calculator : ICreateCalculation, IAddCalculation
    {


        CreateCalculations calculation = new CreateCalculations();
        AddCalculations addCalculations = new AddCalculations();
        public Calculator() { }

        public Calculator(double a, double b, Func<double, double, double> operation)
        {

            CreateCalculation(a, b, operation);

        }
        public void CreateCalculation(double a, double b, Func<double, double, double> operation)
        {

            calculation.CreateCalculation(a, b, operation);
        }

        public void AddCalculation(Calculations calculations)
        {
            addCalculations.AddCalculation(calculations);
            
        }
    }    
    interface ICreateCalculation
    {
        void CreateCalculation(double a, double b, Func<double,double,double>operation);
    }
    public class CreateCalculations : ICreateCalculation
    {

        public void CreateCalculation(double a, double b, Func<double, double, double> operation)
        {
            var _calculation = new Calculations(a, b, operation);
            Console.WriteLine(_calculation.GetResults());
        }
    }

    interface IAddCalculation
    {
        void AddCalculation(Calculations calculations);
    }
    public class AddCalculations : IAddCalculation
    {

        public List<Calculations> Calculations = new List<Calculations>();
        public void AddCalculation(Calculations calculations)
        {
            Calculations.Add(calculations);

        }


    }


}
