using System;
using System.Text;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            quote = quote.Insert(20, " always takes longer than");
            Console.WriteLine(quote);
            Console.ReadLine();

            
        }
    }
}
