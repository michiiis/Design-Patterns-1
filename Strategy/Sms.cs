using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    public class Sms : IMessageType
    {
        public void run(string message)
        {
            Console.WriteLine("Sending Sms: " + message);
        }
    }
}
