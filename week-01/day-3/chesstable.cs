using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            string odd = "% % % % ";
            string even = " % % % %";
            Console.WriteLine("Let's play chess!");
            Console.WriteLine();
            for (int i = 1; i <= 8; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(even);
                }
                else
                {
                    Console.WriteLine(odd);
                }


            }
            Console.ReadLine();
        }
    }
}
