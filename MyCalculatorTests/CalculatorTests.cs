using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using ConsoleCalculator.Models;



namespace MyCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void CalculatorTest()
        {
            Calculator _calculator = new Sum();
            Assert.IsInstanceOfType(_calculator, typeof(Calculator));
        }

        [TestMethod()]
        public void SumTest()
        {
            //arrange
            double _a = 1;
            double _b = 2;
            string _action = "sum";
            Sum _sum = new Sum();
            _sum.CreateCalculation(_a, _b, _action);


            var _result = _sum.calculations[0].GetResults();
            Console.WriteLine(_result);


        }
        [TestMethod()]
        public void DifferenceTest()
        {
            double _a = 15;
            double _b = 5;
            string _action = "difference";

            Difference _difference = new Difference();

            _difference.CreateCalculation(_a, _b, _action);

            var _result = _difference.calculations[0].GetResults();
            Console.WriteLine(_result);


        }


        [TestMethod()]
        public void MultiplicationTest()
        {
            double _a = 15;
            double _b = 5;
            string _action = "multiplication";

            Multiplication _multiplication = new Multiplication();

            _multiplication.CreateCalculation(_a, _b, _action);

            var _result = _multiplication.calculations[0].GetResults();
            Console.WriteLine(_result);

        }
        [TestMethod()]
        public void DivisionTest()
        {
            double _a = 15;
            double _b = 5;
            string _action = "division";


           Division _division = new Division();

            _division.CreateCalculation(_a, _b, _action);

            var _result = _division.calculations[0].GetResults();
            Console.WriteLine(_result);
        }
        [TestMethod()]
        public void CalculationListTest()
        {

            Calculator _multiply = new Multiplication();
            Calculator _divide = new Division();
            Calculator _add = new Sum();
            Calculator _subtract = new Difference();
            
            
            double _a = 4;
            double _b = 2;
            
            string _action = "multiplication";
            _multiply.CreateCalculation(_a, _b, _action);

            _action = "division";
            _divide.CreateCalculation(_a, _b, _action);


            _action = "sum";
            _add.CreateCalculation(_a, _b, _action);


            _action = "difference";
            _subtract.CreateCalculation(_a, _b, _action);



            _subtract.calculations.ForEach(action: delegate (Calculations calculations)
            {
                Console.WriteLine(calculations.GetResults());
               
            });

        }
    }
}