using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MyCalculator.EventPublisher;

namespace ConsoleEventHandler.Interface
{
    public interface IConsoleObserver
    {
        void Update(ConsoleEventManager subject);
    }
    public interface ICalcObserver
    {
        
    }
}
