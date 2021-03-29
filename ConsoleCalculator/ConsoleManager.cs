using System;
using System.Collections.Generic;
using MyCalculator.EventPublisher;
using MyCalculator.CalculatorFunctions;
using MyCalculator.Builders;
using MyCalculator;
using ConsoleEventHandler.ConsolePublisher;
using ConsoleCalculator.Subscribers;
using ConsoleEventHandler;
using ConsoleCalculator.RegisterEvents;
using ConsoleEventHandler.Observers;
using ConsoleCalculator.Factory;
namespace ConsoleCalculator
{
    public class ConsoleManager
    {
        public static CalculatorBuilder _calculatorBuilder = new CalculatorBuilder();
        public static Calculator _calculator = new Calculator(_calculatorBuilder);
        ConsoleEventManager _consoleEventManager = new ConsoleEventManager();
        EventRegister _consoleEvent = new EventRegister(_calculator);
        ConsoleCalcObserver _calculationObserver = new ConsoleCalcObserver();

        public void Start()
        {
            bool _finalDecision = true;
            _consoleEventManager.ConsoleStartUp();
            while (_finalDecision)
            {
                var _action = _consoleEventManager.UserInputAction();
                double _firstInput = _consoleEventManager.UserInputDouble();

                double _secondInput = _consoleEventManager.UserInputDouble();

                _consoleEventManager.DivideByZeroException(_action, _secondInput);
                PerformCalculation(_firstInput, _secondInput, _action);

                MenuOptions();
                

            }
        }

        void MenuOptions()
        {
            MenuOptionsEventTrigger();
            var inputOp = new InputOptionFactory();
            string _option = Console.ReadLine();
            inputOp.getOptionStrategy(_option).getOption();
          
        }

        public void PerformCalculation(double firstInput, double secondInput, Func<double, double, double> action)
        {
            _consoleEventManager.Attach(_calculationObserver);
            _consoleEvent.RegisterDisplayCalculationEvent();
            var _result = _calculator.CreateCalculation(firstInput, secondInput, action);
            _consoleEventManager.Notify();
            _consoleEvent.UnregisterDisplayCalculationEvent();
            _consoleEventManager.Detach(_calculationObserver);
        }
        void MenuOptionsEventTrigger()
        {
            _consoleEventManager._eventRegister.RegisterConsoleOptionsEvent();
            _consoleEventManager._eventRegister._consoleEvent.ConsoleOptions();
            _consoleEventManager._eventRegister.UnregisterConsoleOptionsEvent();
        }
        public void GetCalculationList()
        {

            _consoleEvent.RegisterListOfCalculationsEvent();
            _calculator._calcEvent.UseCalculator(_calculatorBuilder);
            _consoleEvent.UnregisterListOfCalculationsEvent();

        }



    }
}
