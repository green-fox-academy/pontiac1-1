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
            string pathToCopyFrom = @"c:\users\test\source\repos\ConsoleApp69\ConsoleApp69\TextFile1.txt";
            string pathToPasteTo = @"c:\users\test\source\repos\ConsoleApp69\ConsoleApp69\TextFile2.txt";
            if (!File.Exists(pathToPasteTo))
            {
                File.Open(pathToPasteTo, FileMode.Create);
            }

            string[] content = File.ReadAllLines(pathToCopyFrom);
            File.WriteAllLines(pathToPasteTo, content);

            string[] content2 = File.ReadAllLines(pathToPasteTo);

            if (content == content2)
            {
                return;
            }
            Console.Read();
        

        }
        
    }
}
