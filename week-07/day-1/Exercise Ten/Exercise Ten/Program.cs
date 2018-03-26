using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_Ten
{
    class Program
    {
        static void Main(string[] args)
        {
            var FoxList = new List<Fox>();
            FoxList.Add(new Fox("Heki", "pallida", "green"));
            FoxList.Add(new Fox("Kaki", "stromtrooperfox", "white"));
            FoxList.Add(new Fox("Muki", "snowtrooperfox", "white"));
            FoxList.Add(new Fox("Miki", "ultrafox", "orange"));
            FoxList.Add(new Fox("Feri", "pallida", "black"));

            //Query Syntax for greenfox
            var GreenFoxesWithQuery = from fox in FoxList
                                      where fox.color == "green"
                                      select fox;

            foreach (var fox in GreenFoxesWithQuery)
                Console.WriteLine(fox.name);

            //Method Syntax for greenfox
            var GreenFoxesWithMethod = FoxList.Where(fox => fox.color == "green");

            foreach (var fox in GreenFoxesWithMethod)
                Console.WriteLine(fox.name);

            //Query Syntax for pallida greenfox
            var GreenOrPallidaFoxQuery = from fox in FoxList
                                         where fox.color == "green" || fox.type == "pallida"
                                         select fox;

            foreach (var fox in GreenOrPallidaFoxQuery)
                Console.WriteLine(fox.name);

            //Method Syntax for pallida greenfox
            var GreenOrPallidaFoxMethod = FoxList.Where(fox => fox.color == "green" || fox.type == "pallida");

            foreach (var fox in GreenOrPallidaFoxMethod)
                Console.WriteLine(fox.name);

            Console.Read();
        }
    }
}
