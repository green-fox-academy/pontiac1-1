using System;

namespace ConsoleApp4
{
    class codinghoures
    {
        static void Main(string[] args)
        {
            byte avg = 6;
            byte lenght = 17;
            byte workdays = 5;
            int codingh = avg * lenght * workdays;

            Console.WriteLine(codingh);


            double total = lenght * 7 * 24;
            double perc = codingh / (total / 100);

            Console.WriteLine(perc + "%");

            Console.ReadLine();
            
        }
    }
}
