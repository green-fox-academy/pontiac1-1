using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = new int[] { 1, 2, 3 };
            int[] p2 = new int[] { 4, 5 };
            int p1length = p1.Length;
            int p2length = p2.Length;
            if (p1length < p2length)
            {
                Console.WriteLine("p2 has more items");
            }
            else
            {
                Console.WriteLine("p1 has more or equal items");
            }
            Console.ReadLine();
        }
    }
}
