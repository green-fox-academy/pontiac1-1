using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp75
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\users\test\source\repos\ConsoleApp75\ConsoleApp75\decode.txt";
            string[] lines = File.ReadAllLines(path);
            List<char> chars = new List<char>();
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j]!=' ')
                    {
                    char shifted = (char)((int)lines[i][j] - 1 );
                    Console.Write(shifted);
                        
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                    
                }
                Console.WriteLine();
                
            }
            

            
            Console.Read();
        }
    }
}
