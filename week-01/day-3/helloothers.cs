using System;

namespace ConsoleApp1
{
    class helloothers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Mik. great three of your classmates! Who do you want to greet?");

            string firstname = Console.ReadLine();
            string secondname = Console.ReadLine();
            string thirdname = Console.ReadLine();

            if (firstname.Length > 0 && secondname.Length > 0 && thirdname.Length > 0)
            {
                Console.WriteLine("Hello " + firstname + secondname + thirdname);
            }
            else
            {
                Console.WriteLine("pls enter all three names to greet them, dont be an asshole!");
            }

            Console.ReadLine();
            
        }
    }
}
