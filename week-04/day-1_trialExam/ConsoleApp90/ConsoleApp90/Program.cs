using System;
using System.IO;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Text.txt";
            CountAs(file);
            Console.Read();
        }
        static void CountAs(string file)
        {
                int freqA = 0;
            try
            {
                string content = File.ReadAllText(file);
                for (int i = 0; i < content.Length; i++)
                {
                    if (content[i] == 'a')
                    {
                        freqA++;
                    }
                }
            }
            catch(Exception)
            {

            }
            finally
            {
            Console.WriteLine(freqA);
            }
            
        }
    }
}
