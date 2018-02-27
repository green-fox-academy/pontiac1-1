using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-03\day-2\my-file";
            try
            {
                string name = "Steve Bannon";
                File.WriteAllText(path, name);
                throw new Exception("unable to coply");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
