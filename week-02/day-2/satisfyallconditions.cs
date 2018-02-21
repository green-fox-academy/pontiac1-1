using System;
using System.Collections.Generic;

namespace ConsoleApp60
{
    class satisfyallconditions
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            Console.WriteLine(Colt(list));
            Console.ReadLine();

        }
        static bool Colt(List<int> a)
        {

            bool namivan = a.Contains(4) && a.Contains(8) && a.Contains(12) && a.Contains(16);
            return namivan;

        }
    }
}
