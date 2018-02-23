using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word");
            string a = Console.ReadLine();
            Console.WriteLine("enter another word");
            string b = Console.ReadLine();
            int match = 0;
            if (a.Length!=b.Length)
            {
                Console.WriteLine("not anagrams");
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {

                        if (a[i] == b[j])
                        {
                            match++;
                            break;
                        }

                    }
                }
                if (a.Length == match)
                {
                    Console.WriteLine("the words youve entered are anagrams");
                }
                else
                {
                Console.WriteLine("the word youve entered are not anagrams");
                }
                Console.ReadLine();
            }
            
            Console.WriteLine(match);
        }
    }
}
