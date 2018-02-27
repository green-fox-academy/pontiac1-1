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
            string path = @"c:\users\test\source\repos\ConsoleApp69\ConsoleApp69\TextFile1.txt";
            Write(path,"apple",10);
            string[] content = File.ReadAllLines(path);

            foreach (var words in path)
            {
                Console.WriteLine(File.ReadAllLines(path));
            }
            Console.ReadLine();
        }
        public static void Write(string path, string word, int lines)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < lines; i++)
                {
                    writer.WriteLine(word);
                }
            }


        }
        
    }
}
