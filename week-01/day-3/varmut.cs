using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            a += 10;
            Console.WriteLine(a);

            int b = 100;
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            c += c;
            Console.WriteLine(c);

            int d = 125;
            d /= 5;
            Console.WriteLine(d);

            int e = 8;
            e = e * e * e;
            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            if (f1 > f2)
            {
                Console.WriteLine("f1 is bigger than f2");
            } else
            {
                Console.WriteLine("f1 is not bigger than f2");
            }

            int g1 = 350;
            int g2 = 200;
            g2 *= 2;
            if (g2 > g1)
            {
                Console.WriteLine("g2 is bigger than g1");
            } else
            {
                Console.WriteLine("g2 is not bigger then g1");
            }

            int i1 = 10;
            int i2 = 3;
            int i2s = i2 * i2;
            int i2c = i2 * i2 * i2;
            if (i2s < i1) {
                Console.WriteLine("ii is bigger than i2 square");
            }
                
            else if (i2c < i1)
            {
                Console.WriteLine("ii is bigger than i2 on the power if three");
            }
            else
            {
                Console.WriteLine("i1 is a small ass num");
            }
            Console.ReadLine();





        }
    }
}
