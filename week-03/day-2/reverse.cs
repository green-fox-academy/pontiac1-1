using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp73
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\users\test\source\repos\ConsoleApp73\ConsoleApp73\reverse.txt";
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = lines[i].Length-1; j >= 0; j--)
                {
                    Console.Write(lines[i][j]);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
