using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who do you want to greet?");
            string togreet = Console.ReadLine();
            Console.WriteLine(Greet(togreet));
            Console.ReadLine();
        }
        static string Greet(string togreet)
        {
            string text = "Hello my friend, "+togreet+"!";
            return text;
        }
    }
}
