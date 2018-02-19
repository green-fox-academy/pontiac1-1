using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter a word to finish later!");
            string firstpart = Console.ReadLine();
            Console.WriteLine(Second(firstpart));
            Console.ReadLine();

        }
        static string Second(string a)
        {
            Console.WriteLine("pls enter te second part of the word to finish it!");
            string secondpart = Console.ReadLine();
            string word = a + secondpart;
            return word;
        }
    }
}
