using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter a num to double!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Multiply(a));
            Console.ReadLine();
        }

        static int Multiply(int a)
        {
            int result = 2 * a;
            return result;
        }
    }
}
