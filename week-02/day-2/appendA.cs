using System;
using System.Collections.Generic;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            AppandA(far);
            foreach(string item in far)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        static List<string> AppandA(List<string> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                a[i] += "a";
            }
            return a;
        }
    }
}
