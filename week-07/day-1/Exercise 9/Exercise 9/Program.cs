using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = new char[] { 's', 'p', 'l', 'a', 's', 'h' };

            //Query Syntax
            var charactersToStringWithQuery = String.Join("", from c in characters
                                                              select c);

            Console.WriteLine(charactersToStringWithQuery);

            //Method Syntax
            var charactersToStringWithMethod = String.Join("", characters.Select(c => c));

            Console.WriteLine(charactersToStringWithMethod);
            Console.Read();
                                         


        }
    }
}
