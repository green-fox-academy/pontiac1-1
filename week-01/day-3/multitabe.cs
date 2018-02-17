using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter an int to show the multilication table for");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++) {

                Console.WriteLine(i * x);
            }
            Console.ReadLine();
        }
    }
}
