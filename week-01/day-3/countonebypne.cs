using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter a num");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("pls enter an other num");
            int y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                Console.WriteLine("second num should be bigger!");
                
            }
            else
            {
                
                while (x <= y) 
                {
                    Console.WriteLine(x++);
                }
            }
            Console.ReadLine();


            
        }
    }
}
