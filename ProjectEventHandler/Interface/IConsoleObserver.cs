using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleEventHandler.Interface
{
    public interface IConsoleObserver
    {
        void Update(ConsoleEventManager subject);
    }
}
