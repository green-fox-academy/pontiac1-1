using System;
using System.Collections.Generic;
using System.IO;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("pls enter a path you wish to work with");
            string mypath = Console.ReadLine();
            Count(mypath);
        }
        public static void Count(string a)
        {
            try
            {
                if (File.Exists(a))
                {
                    Console.WriteLine(File.ReadAllLines(a).Length);
                }
                else
                {
                    throw new Exception("0");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
