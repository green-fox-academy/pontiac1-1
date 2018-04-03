using System;
using System.Linq;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };

            //Query Syntax
            var NumsWithBiggerSqThan20 = from n in numbers
                                         where n * n > 20
                                         select n;

            foreach (var NumWithBiggerSqThan20 in NumsWithBiggerSqThan20)
                Console.WriteLine(NumWithBiggerSqThan20);

            Console.WriteLine();

            //Method Syntax
            var NumsWithBiggerSqThan20Method = numbers.Where(n => n * n > 20);

            foreach (var NumWithBiggerSqthan20Method in NumsWithBiggerSqThan20Method)
                Console.WriteLine(NumWithBiggerSqthan20Method);


            Console.Read();
        }
    }
}
