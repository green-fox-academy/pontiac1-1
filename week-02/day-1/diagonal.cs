using System;

namespace ConsoleApp45
{
    class diagonal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter a number!");
            int num = int.Parse(Console.ReadLine());
            int[,] diagonal = new int[num, num];
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i==j)
                    {
                        diagonal[i, j] = 1;
                    }
                    
                }
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(diagonal[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
                
            




        }
    }
}
