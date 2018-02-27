using System;
using System.Collections.Generic;
using System.IO;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] feed = new string[] {"When people stop believing in God, all kind of hell let lose", "Steve Bannon"};

            string mypath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-03\day-2\my-file.txt";
            try
            {
                File.WriteAllLines(mypath, feed);
                Console.WriteLine(File.ReadAllText(mypath));
                if (!File.Exists(mypath))
                {
                    throw new Exception("NO MY MAN THAT FILE JUST DOESNT EXIST!!!!");
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
