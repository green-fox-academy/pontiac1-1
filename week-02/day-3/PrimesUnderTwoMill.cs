using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 18;
            for (int i = 8; i <=2000000; i++)
            {
                if (i%2!=0 && i%3 !=0 && i%5!=0 && i%7!=0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
