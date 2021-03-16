using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator.ConsolePublisher
{

    //These files are not being used. 
    //Instead the "duplicate" files found in the ConsoleEventHandler Folder are being used instead
    public class ConsoleEventArgs : EventArgs
    {
        public double UserNumberInput { get; set; }
        public Func<double,double,double> UserActionInput { get; set; }

    }
}
