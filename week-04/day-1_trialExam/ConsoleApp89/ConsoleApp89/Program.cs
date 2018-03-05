using System;
using System.Collections.Generic;

namespace ConsoleApp89
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<object>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }
            Seconds(myList);
            Console.Read();
        }
        static List<object> Seconds(List<object> a)
        {
            var newMyList = new List<object>();
            for (int i = 0; i < a.Count; i++)
            {
                if (i%2 == 0)
                {
                    newMyList.Add(a[i]);
                }
            }
            foreach (var item in newMyList)
            Console.WriteLine(item);
            
            return newMyList;
        }
    }
}
