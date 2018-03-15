using System;
using System.Collections.Generic;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            var aquarium = new Aquarium();
            aquarium.Add(new Koi("Nami", 9, "pink"));
            aquarium.Add(new Tang("Dory", 8, "blue", true));
            aquarium.Add(new Tang("Bubbles", 10, "yellow", false));
            aquarium.Add(new Clownfish("Nemo", 5, "orange", "white"));

            aquarium.Status();
            Console.WriteLine();
            aquarium.FeedAll();
            Console.WriteLine();
            aquarium.Remove();
            Console.WriteLine();
            aquarium.Status();

            Console.Read();
        }
    }
}
