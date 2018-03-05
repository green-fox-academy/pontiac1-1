using System;
using System.IO;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Test\Documents\trialexamweek04\exam-trial-basics\countas\text.txt";
            CountAs(path);
            Console.Read();
        }
        static void CountAs(string path)
        {
                int freqA = 0;
            try
            {
                string content = File.ReadAllText(path);
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
