using System;
using System.Collections.Generic;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to my first calculator!\nEnter an operation with two varibales! (the input style shoudl look like * x y");
            var tocalc = Console.ReadLine();
            double x = int.Parse(tocalc[2].ToString());
            double y = int.Parse(tocalc[4].ToString());
            char op = tocalc[0];

            if (op.Equals('+'))
            {
                Console.WriteLine(x + y);
            }
            if (op.Equals('-'))
            {
                Console.WriteLine(x - y);
            }
            if (op.Equals('/'))
            {
                Console.WriteLine(x / y);
            }
            if (op.Equals('*'))
            {
                Console.WriteLine(x * y);
            }
            if (op.Equals('%'))
            {
                Console.WriteLine(x % y);
            }

            Console.ReadLine();


        }
        //static double Calc(string a)
        //{
        //    double result=0;
        //    a.Split(" ");
        //    
        //    int[] splitted = new int[] { };
        //    for (int i = 3; i < a.Length; i+=2)
        //    {
        //        splitted[i] = { a[i] };
        //    }
        //
        //    if (a[0].Equals("+"))
        //    {
        //        result = splitted[2] + splitted[4];
        //    }
        //    return result;
        //    
        //
        //
        //}
        //
    }   //
}       //
