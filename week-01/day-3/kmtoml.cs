using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter an integer: ");
            int km = int.Parse(Console.ReadLine());
            double ml = km * 0.6;

            Console.WriteLine(km+"km = "+ml+"ml");
            Console.ReadLine();
        }
    }
}
