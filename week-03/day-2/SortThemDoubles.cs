using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\users\test\source\repos\ConsoleApp71\ConsoleApp71\Log.txt";
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                  
                        if (j%2==0)
                        {
                            Console.Write(lines[i][j]);
                        }
                        
                    
                }
                    Console.WriteLine();
            }

            
            Console.Read();
        }

        
    }
}
