using System;

namespace Design_Patterns_Assignment.ObserverPattern
{
    internal class Parent : IBarn
    {
        public void Notify(string message)
        {
            Console.WriteLine("Dags att hämta barnet");
        }
    }
}