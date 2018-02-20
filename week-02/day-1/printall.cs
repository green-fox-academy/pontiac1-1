using System;

namespace ConsoleApp35
{
    class printall
    {
        static void Main(string[] args)
        {
            int[] af = new int[] { 4, 5, 6, 7 };
            foreach (int item in af)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
