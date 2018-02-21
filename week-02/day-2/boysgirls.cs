using System;
using System.Collections.Generic;

namespace ConsoleApp56
{
    class boysgirls
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var merged = new List<string>();

            for (int i = 0; i < girls.Count; i++)
            {
                merged.Add(boys[i]);
                merged.Add(girls[i]);
            }
            foreach (var item in merged)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

    }
}
