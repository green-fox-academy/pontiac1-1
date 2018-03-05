using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Counter(20));
            Console.Read();

        }
        static public int SumOfInt(int baseInt, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                return baseInt * SumOfInt(baseInt, power - 1);
            }

        }
        static public int Counter(int a)
        {
            if (a==0)
            {
                
                return 0;
            }
            else
            {
                Console.WriteLine(a);
                return Counter(a - 1);
            }
        }

        static public double Bunnies(int a)
        {
            if (a == 1)
            {
                return 2;
            }
            else
            {

                if (a % 2 == 0)
                {
                    return 3 + Bunnies(a - 1);
                }
                else
                {
                    return 2 + Bunnies(a - 1);
                }
            }
        }

        static public double Fib(int a)
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
                return Fib(a - 1) + Fib(a - 2);
            }
        }
        static public double Factorial(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            else
            {
                return a * Factorial(a - 1);
            }
        }
        static public int SumDig(int a)
        {
            if (a % 10 == 0)
            {
                return a;
            }
            else
            {
                return a % 10 + SumDig(a / 10);
            }
        }

    }
}
