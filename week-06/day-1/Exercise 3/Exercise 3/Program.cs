using System;
using System.Linq;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //Query Syntax
            var sqNums = from n in numbers
                         select n * n;

            foreach (var sqNum in sqNums)
            {
                Console.WriteLine(sqNum);
            }

            Console.WriteLine();

            //Method Syntax
            var squareNums = numbers.Select(n => n * n);
            
            foreach(var squareNum in squareNums)
            {
                Console.WriteLine(squareNum);
            }

            Console.Read();
        }
    }
}
