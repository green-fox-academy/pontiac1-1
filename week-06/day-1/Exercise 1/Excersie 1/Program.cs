﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Excersie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //Query Syntax
            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              select n;

            foreach (var evenNumber in evenNumbers)
                Console.WriteLine(evenNumber);

            Console.WriteLine();

            //Method Syntax
            var evenNumbersWithMethodSyntax = numbers.Where(n => n % 2 == 0);

            foreach (var evenNumberWithMethodSyntax in evenNumbersWithMethodSyntax)
                Console.WriteLine(evenNumberWithMethodSyntax);

            Console.Read();
        }
    }
}
