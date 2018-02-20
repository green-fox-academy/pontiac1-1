using System;

namespace ConsoleApp42
{
    class summing
    {
        static void Main(string[] args)
        {
            int[] ai = new int[] { 3, 4, 5, 6, 7 };
            int sum = 0;
            foreach (var item in ai)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            
        }
    }
}
