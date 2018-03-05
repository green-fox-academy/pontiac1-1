using System;
using System.Collections.Generic;

namespace ConsoleApp91
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPirates = new List<Pirate>();

            myPirates.Add(new Pirate("Arno", true, 200));
            myPirates.Add(new Pirate("Gomez", true, 10));
            myPirates.Add(new Pirate("Tom Petty", true, 100));
            myPirates.Add(new Pirate("Gerda", false, 8));
            myPirates.Add(new Pirate("Miki", false, 0));
            myPirates.Add(new Pirate("Knopfler", true, 113));
            myPirates.Add(new Pirate("Gilmour", false, 12));

            GoldCount(myPirates);
            Console.Read();
        }
        static List<Pirate> GoldCount(List<Pirate> a)
        {
            var myPiratesSorted = new List<Pirate>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].HasWoodenLeg == true && a[i].Gold > 15)
                {
                    myPiratesSorted.Add(a[i]);
                }
            }
            foreach (var pirate in myPiratesSorted)
            {
                Console.WriteLine(pirate.Name);
            }
            return myPiratesSorted;
        }
    }
}
