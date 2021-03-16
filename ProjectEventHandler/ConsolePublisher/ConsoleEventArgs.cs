using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEventHandler.ConsolePublisher
{
    public class ConsoleEventArgs : EventArgs
    {
        public double UserNumberInput { get; set; }
        public Func<double,double,double> UserActionInput { get; set; }

    }
}
