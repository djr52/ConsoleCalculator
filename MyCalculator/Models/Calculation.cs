using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Interfaces;

namespace ConsoleCalculator.Models
{


    public class Calculation : ICalculation
    {
        //store 1 value
        public double A { get; set; }
        //store 1 value
        public double B { get; set; }
        //store a single operation function
        public Func<double, double, double> Operation { get; set; }

        //constructor for 3 param (Double, Double, Function)
        public Calculation(double a, double b, Func<double, double, double> calculation)
        {
            A = a;
            B = b;
            //this stores the operation to be performed on A and B
            Operation = calculation;
        }
        //constructor with 0 param

        public Calculation() { }

        public static Calculation Create(double a, double b, Func<double, double, double> calculation) //Static factory Create method creates the object for easy instatiation
        {
            var _calculation = new Calculation(a, b, calculation);
            return _calculation;
        }


        //This calls whatever operation was stored i.e. mult, div, add, sub and returns the answer
        public double GetResult()
        {
            return Operation(A, B);

        }

    }






}





