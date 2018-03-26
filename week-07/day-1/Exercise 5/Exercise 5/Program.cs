using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //Query Syntax
            var FreqWithQuery = from n in numbers
                                group n by n;

            foreach (var freq in FreqWithQuery)
            {
                Console.WriteLine(freq.Key + " " + freq.Count());
            }

            Console.WriteLine();

            //Method Syntax
            var FreqWithMethod = numbers.GroupBy(n => n);

            foreach (var item in FreqWithMethod)
            {
                Console.WriteLine(item.Key + " " + item.Count());
            }
            

            Console.Read();
        }
    }
}
