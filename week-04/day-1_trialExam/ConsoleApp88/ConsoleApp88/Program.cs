using System;

namespace ConsoleApp88
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCube = new Cuboid(10, 10, 10);
            myCube.GetSurface();
            Console.Read();
        }
    }
}
