using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            //Query Syntax
            var CityWithStartAEndI = from c in cities
                                     where c.StartsWith('A') && c.EndsWith('I')
                                     select c;

            foreach (var city in CityWithStartAEndI)
                Console.WriteLine(city);

            Console.WriteLine();

            //Method Syntax
            var CityWithStartAEndIWithMethod = cities.Where(c => c.StartsWith('A') && c.EndsWith('I'));

            foreach (var city in CityWithStartAEndIWithMethod)
                Console.WriteLine(city);

            Console.Read();
                                     
        }
    }
}
