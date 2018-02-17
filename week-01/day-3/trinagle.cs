using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter a number");
            int numoflines = int.Parse(Console.ReadLine());
            string block = "*";

            for (int i = 1; i <= numoflines; i++)
            {
                Console.WriteLine(block);
                block += "*";
                
            }
            Console.ReadLine();


        }
    }
}
