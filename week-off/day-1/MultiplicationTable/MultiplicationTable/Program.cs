using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Multi(4);
            Console.Read();
        }
        static void Multi(int tomultiply)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i +" * " + tomultiply +" = "+ tomultiply * i);
            }
        }
    }
}
