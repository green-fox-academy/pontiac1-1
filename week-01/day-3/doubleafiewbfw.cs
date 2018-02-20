using System;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 3, 4, 5, 6, 7 };




            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] *= 2;
                Console.WriteLine(ar[i]);
            }
            Console.ReadLine();
        }   
    }
}   
