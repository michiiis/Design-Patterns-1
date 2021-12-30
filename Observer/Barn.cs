using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    class Barn : IBarn
    {
        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
