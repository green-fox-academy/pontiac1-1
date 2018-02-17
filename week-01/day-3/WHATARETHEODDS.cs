using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter an integer to evaluate!");
            int x = int.Parse(Console.ReadLine());
            if (x%2 == 0)
            {
                Console.WriteLine("the int youve entered is even");
            } else
            {
                Console.WriteLine("the int youve entered is odd");
            }
            Console.ReadLine();
        }
    }
}
