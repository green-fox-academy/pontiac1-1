using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\users\test\source\repos\ConsoleApp74\ConsoleApp74\order.txt";
            string[] lines = File.ReadAllLines(path);
            for (int i = lines.Length-1; i >= 0; i--)
            {
                Console.WriteLine(lines[i]);
            }
            Console.Read();
        }
    }
}
