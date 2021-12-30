using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    class Observer
    {
        internal static void Run()
        {
            Lärare lärare = new();
            var antalFöräldrar = 5;

            List<Barn> barnList = new(); 

            for (int i = 0; i < 4; i++)
            {
                Barn barn = new Barn();
                lärare.LäggTillObserver(barn);
                barnList.Add(barn);
            }

            for (int i = 0; i < antalFöräldrar; i++)
            {
                Parent parent = new();
                lärare.LäggTillObserver(parent);
            }

            lärare.KollaOmDetÄrDagsFörRast();

            for (int i = 0; i < antalFöräldrar; i++)
            {
                if (barnList.Count>0)
                {
                var B = barnList.First();
                lärare.TaBortObservers(B);
                barnList.Remove(B);
                }
            }

            lärare.KollaOmDetÄrDagsFörRast();
        }
    }
}

// observer vill veta när något händer = barnen
// subject den som har svaret = läraren

// lista på observer
// metod för att lägga till observers
// metod för att ta bort observers

// metod för att berätta för observers att någonting har hänt
// går igenom listan på observers och notifierar dom om att något har hänt - kör en metod på varje observer

// barn : IObserver
// public void notify()
// {
//    console.writeline("Hurrah");
// }

// foreach observer in observers kör notify
