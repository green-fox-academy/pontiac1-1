using System;
using System.Collections.Generic;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            Candyland(list);
            foreach(var sweets in list)
            {
                Console.WriteLine(sweets);
            }
            Console.ReadLine();

        }


        static List<object> Candyland(List<object> a)
        {
            for (int i = 0; i <a.Count; i++)
            {
                if (a[i].Equals(2))
                {
                    a[i] = "Croissant";
                }
                if (a[i].Equals(false))
                {
                    a[i] = "Ice cream";
                }
            }
            return a;

        }
    }
}
