using System;
using System.Collections.Generic;
using System.Text;
using MyCalculator.EventPublisher;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Builders;
using MyCalculator;
using ConsoleEventHandler;
using ConsoleCalculator.Subscribers;

namespace ConsoleCalculator.RegisterEvents
{
    public class EventRegister
    {
        Calculator _calculator;
        ConsoleEventManager _consoleEventManager = new ConsoleEventManager();
        DisplayCalculation displayCalc = new DisplayCalculation();
        DisplayListOfCalculations displayCalcList = new DisplayListOfCalculations();
        public EventRegister(Calculator calculator)
        {
            this._calculator = calculator;
        }
        public void RegisterDisplayCalculationEvent()
        {
            _calculator._calcEvent.CalculationCompleted += displayCalc.OnCalculation;

        }
        public void UnregisterDisplayCalculationEvent()
        {
            _calculator._calcEvent.CalculationCompleted -= displayCalc.OnCalculation;

        }
        public void RegisterListOfCalculationsEvent()
        {
            _calculator._calcEvent.UsingCalculator += displayCalcList.OnCalculator;
        }
        public void UnregisterListOfCalculationsEvent()
        {
            _calculator._calcEvent.UsingCalculator -= displayCalcList.OnCalculator;
        }



    }
}
