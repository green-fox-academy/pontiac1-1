using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\users\test\source\repos\ConsoleApp70\ConsoleApp70\O.txt";
            Winner(path);

        }
        static void Winner(string txt)
        {
            string[] lines = File.ReadAllLines(txt);
            int matchforO = 0;
            int matchforX = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines.Length; j++)
                {
                    if (lines[j][i] == 'O')
                    {
                        matchforO++;
                    }
                    if (lines[j][i] == 'X')
                    {
                        matchforX++;
                    }
                }
                if (matchforO == 3)
                {
                    Console.WriteLine("O");
                    break;
                }
                if (matchforX == 3)
                {
                    Console.WriteLine("X");
                    break;
                }
                else
                {
                    Console.WriteLine("DRAW");
                    break;
                }
            }
            if (lines[0][0] == lines[1][1] && lines[1][1] == lines[2][2])
            {
                if (lines[1][1] == 'O')
                {
                    Console.WriteLine("O");
                    
                }
                if (lines[1][1] == 'X')
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("DRAW");
                }
            }
            if (lines[0][2] == lines[1][1] && lines[1][1] == lines[2][0])
            {
                if (lines[1][1] == 'O')
                {
                    Console.WriteLine("O");
                }
                if (lines[1][1] == 'X')
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("DRAW");
                }
            }
            Console.Read();
        }
    }
}
