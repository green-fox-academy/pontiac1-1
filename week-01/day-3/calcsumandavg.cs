using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of integers you wish to work with!");
            int x = int.Parse(Console.ReadLine());
            double[] set = new double[x+1];
            double sum = 0;
            double avg = 0;

            for (int i = 1; i <= x; i++)
            {
                set[i] = double.Parse(Console.ReadLine());
            }

            foreach (var item in set)
            {
                sum += item;
                avg = sum / x;
            }

            Console.WriteLine(sum);
            Console.WriteLine(avg);

            Console.ReadLine();
        }
    }
}



