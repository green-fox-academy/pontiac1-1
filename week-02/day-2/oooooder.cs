using System;
using System.Collections.Generic;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            Order(list);
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();

        }
        static List<string> Order(List<string> a)
        {
            var ordered = new List<string> { "What", "I", "cannot", "create", "I", "do", "not", "understand." };
            for (int i = 0; i < a.Count; i++)
            {
                if (!(a[i] == ordered[i]))
                {
                    a[i] = ordered[i];
                }
            }
            return a;
        }

    

    }
}

