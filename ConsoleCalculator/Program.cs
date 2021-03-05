using System;
using MyCalculator;
using MyCalculator.Builders;
using MyCalculator.CalculatorFunctions;
namespace ConsoleCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            var builtCalculator = new CalculatorBuilder();
            Calculator _calculator = new Calculator(builtCalculator);

            CalcValueEvent calcValue = new CalcValueEvent();
            calcValue.ProcessCompleted += CalcProcessCompleted;


            double _firstInput = UserInputDouble();
           //calcValue.StartProcess(_firstInput);
            double _secondInput = UserInputDouble();
            //calcValue.StartProcess(_secondInput);

            Func<double, double, double> _action = Operations.Sum;



            var _result = _calculator.CreateCalculation(_firstInput, _secondInput, _action);

            calcValue.StartProcess(_result.GetResult());


        }
        static double UserInputDouble()
        {
            Console.WriteLine("Hello! Please enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            return userInput;
        }
        public static void CalcProcessCompleted(object sender, double value) //this is the event handler
        {
            Console.WriteLine("Calculation Event Finished. Result: " + value);
        }



    }
    public class CalcValueEvent
    {
        public event EventHandler<double> ProcessCompleted;
        public void StartProcess(double value)
        {
            try
            {
                Console.WriteLine("Process Started");

                OnProcessCompleted(value);

            }
            catch(Exception ex)
            {
                OnProcessCompleted(0);
            }
        }
        protected virtual void OnProcessCompleted(double value)
        {
            ProcessCompleted?.Invoke(this, value);
        }

    }

}
