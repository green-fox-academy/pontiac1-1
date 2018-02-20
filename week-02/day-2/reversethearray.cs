using System;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            Console.WriteLine(Reverse(original));
            Console.ReadLine();

        }

        static string Reverse(string a)
        {
            string reverse = "";
            for (int i = a.Length - 1; i >= 0 ; i--)
            {
                reverse += a[i];
            }
            return reverse;
        }
    }
}
