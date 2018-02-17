using System;

namespace ConsoleApp6
{
    class swapnums
    {

        static void SwapNum(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        
        }
        static void Main(string[] args)
        {
            int x = 123;
            int y = 526;

            SwapNum(ref x, ref y);
            Console.WriteLine("int x =" +x);
            Console.WriteLine("int y =" + y);
            Console.ReadLine();
        }
    }
}
