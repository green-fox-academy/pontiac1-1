using System;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = new string[] { "first", "second", "third" };
            string temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;
            foreach (var item in abc)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
