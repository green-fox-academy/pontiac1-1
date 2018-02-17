using System;

namespace ConsoleApp24
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int life = 10;

            Console.WriteLine("pls enter a number");
            Console.CursorVisible = false;
            int x = int.Parse(Console.ReadLine());
            
            Console.WriteLine("pls enter a number to guess");
            int y = int.Parse(Console.ReadLine());




                while (y != x && life>0)
                {
                    if(y < x)
                    {
                        Console.WriteLine("No good my man, go up! Youve got " + life + " lives left");
                        y = int.Parse(Console.ReadLine());
                        life--;
                    }

                    if (y > x)
                    {
                        Console.WriteLine("No good my man, go down! Youve got " + life + " lives left");
                        y = int.Parse(Console.ReadLine());
                        life--;
                    }
           
                }


                if (y == x)
                {
                    Console.WriteLine("OHH MY MY, OH HELL YES!");
                    Console.ReadLine();
                }

                if (life == 0)
                {
                    Console.WriteLine("bad luck my friend...");
                    Console.ReadLine();
                }
            


        }
    }
}
