using System;

namespace Fibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibo(10));
            Console.Read();
        }
        static public double Fibo(int a)
        {
            if (a == 0)
            {
                return 0;
            }
            if (a == 1)
            {
                return 1;
            }
            else
            {
                return Fibo(a - 1) + Fibo(a - 2);
            }
        }
    }
}
