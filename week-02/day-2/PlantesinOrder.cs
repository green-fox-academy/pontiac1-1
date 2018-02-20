using System;
using System.Collections.Generic;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            var planets = new List<string> { "Mercury",  "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            All(planets);
            foreach (var item in planets)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
        static List<string> All(List<string> a)
        {
            string[] allplanets = new string[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            for (int i = 0; i < allplanets.Length; i++)
            {
                if (!(a.Contains(allplanets[i])))
                {
                    a.Insert(i, allplanets[i]);
                }
            }

            return a;

        }
    }
}
