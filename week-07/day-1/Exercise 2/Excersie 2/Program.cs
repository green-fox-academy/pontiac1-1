using System;
using System.Linq;

namespace Excersie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //Query Syntax
            var OddNumbers = from n in numbers
                              where n % 2 != 0
                              select n;

            //Get avg with Method Syntax
            double AvgOfOddNumbers = OddNumbers.Average();

            Console.WriteLine(AvgOfOddNumbers);
            Console.Read();
        }
    }
}
