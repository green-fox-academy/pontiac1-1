using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp88
{
    class Cuboid
    {
        public double dimOne;
        public double dimTwo;
        public double dimThree;
        public double Sa;
        public double V;

        public Cuboid(double a, double b, double c)
        {
            this.dimOne = a;
            this.dimTwo = b;
            this.dimThree = c;
        }

        public void GetSurface()
        {
            Sa = 2 * (dimOne * dimTwo) + 2 * (dimOne * dimThree) + 2 * (dimTwo * dimThree);
            Console.WriteLine(Sa);
        }

        public void GetVolume()
        {
            V = dimOne * (dimTwo * dimThree);
            Console.WriteLine(V);
        }
    }
}
