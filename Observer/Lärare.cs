using System;
using System.Collections.Generic;
using System.Threading;

namespace Design_Patterns_Assignment.ObserverPattern
{
    internal class Lärare
    {
        internal void KollaOmDetÄrDagsFörRast()
        {
            int evenMinute = 0;
            while (true)
            {
                evenMinute = DateTime.Now.Second % 10;
                Thread.Sleep(1000);
                if (evenMinute==0)
                {
                    foreach (var barn in ListaPåObservers)
                    {
                        barn.Notify("Dags för rast");
                    }
                    break;
                }            
        }
    }

        private List<IBarn> ListaPåObservers { get; set; }
        public Lärare()
        {
            ListaPåObservers = new();
        }
        public void LäggTillObserver(IBarn Barn)
        {
            ListaPåObservers.Add(Barn); 
        }
        public void TaBortObservers(IBarn Barn)
        {
            ListaPåObservers.Remove(Barn);
        }
    }
}