using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "I woke up early this morning, The Sun came shining down";

            //Query Syntax
            var UpperCasesWithQuery = from c in content
                                      where char.IsUpper(c)
                                      select c;

            foreach (var upperCaseCharacter in UpperCasesWithQuery)
                Console.WriteLine(upperCaseCharacter);

            Console.WriteLine();

            //Method Syntax
            var UpperCaseWithMethod = content.Where(c => char.IsUpper(c));

            foreach (var upperCaseCharacter in UpperCaseWithMethod)
                Console.WriteLine(upperCaseCharacter);

            Console.Read();
        }
    }
}
