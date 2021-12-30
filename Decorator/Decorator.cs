using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.DecoratorAssignment;
using System;

namespace Design_Patterns_Assignment
{
    internal class Decorator2
    {
        internal static void Run()
        {
            IDecoration anyKindOfDoll;

            Console.WriteLine("Skriv in texten");
            Text originalDoll = new();
            originalDoll.TheText = Console.ReadLine();

            anyKindOfDoll = originalDoll;
            
            Console.WriteLine("Välj en dekorator");
            ConsoleKey TextInput = new();
            while (true)
            {
                TextInput = Console.ReadKey(intercept: true).Key;
                switch (TextInput)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        anyKindOfDoll = new Bold(anyKindOfDoll);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        string hundvalp = anyKindOfDoll.Content();
                        Console.WriteLine(hundvalp);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        anyKindOfDoll = new Italic(anyKindOfDoll);
                        break;

                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

/*
 * du har ryska dockor - 2 olika typer
 * 1 typ som är ursprungsdockan som inte går att öppna
 * 1 typ dekoreringsdockor som går att öppna o stoppa in antingen dekoreringsdockor i eller ursprungsdockor i -implementerar samma interface
 * ursprungsdockans funktion returnerar bara ett värde..
 * dekoreringsdockor returnerar sitt värde + värdet på dockan dom har inuti
 * 
 * D -> D -> D -> U
 * 
 * ursprungsdockan = text
 * gettext - return text
 * 
 * bold docka property IDocka docka
 * return text + docka.gettext 
 * 
 */