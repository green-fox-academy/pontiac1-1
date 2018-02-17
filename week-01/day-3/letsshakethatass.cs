using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter the num of girls coming to the party");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("pls enter the num of boys coming to the party");
            int b = int.Parse(Console.ReadLine());
            int t = g + b;

            if (g == b && t > 20)
            {
                Console.WriteLine("The party is exellent!");
            }
            if (!(g == b) && t > 20)
            {
                Console.WriteLine("Quite cool party!");
            }
            if (t < 20)
            {
                Console.WriteLine("Average party...");
            }
            if (g == 0)
            {
                Console.WriteLine("Sausage party");
            }


            Console.ReadLine();
        }
    }
}