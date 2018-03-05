using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ani
{
    public class Animal
    {
        public double hunger;
        public double thirst;

        public Animal(double hunger= 50, double thirst = 50)
        {
            this.hunger = hunger;
            this.thirst = thirst;

        }
        public void eat()
        {
            hunger--;
        }
        public void drink()
        {
            thirst--;
        }
        public void play()
        {
            hunger++;
            thirst++;
        }




    }
}
