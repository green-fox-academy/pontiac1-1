using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number to gain its factorial value!");
            int tofactor = int.Parse(Console.ReadLine());
            Console.WriteLine("The factored value of "+tofactor+" is "+Factor(tofactor));
            Console.ReadLine();

        }
        static double Factor(int a)
        {
            int factoredvalue = a;
            for (int i = a-1; i >= 1; i--)
            {
                factoredvalue *= i;
            }
            return factoredvalue;
        }
    }
}
