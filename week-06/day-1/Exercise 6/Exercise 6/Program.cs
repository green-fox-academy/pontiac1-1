using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "It's good to be king";

            //Query Syntax
            var CharFreqWithQuery = from c in content
                                    group c by c into Freq
                                    select Freq.Count();

            foreach (var character in CharFreqWithQuery)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine();

            //Method Syntax
            var CharFreqWithMethod = content.GroupBy(c => c);

            foreach (var character in CharFreqWithMethod)
            {
                Console.WriteLine(character.Count());
            }
            Console.Read();
        }
    }
}
