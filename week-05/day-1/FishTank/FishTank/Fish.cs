using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    public class Fish
    {
        public string name;
        protected string color;
        public float mass;
        protected string pattern;
        protected bool whereAmI;

        public virtual float Feed()
        {
            mass++;
            return mass;
        }

        public void Status()
        {
            Console.WriteLine("Name: {0}, Color: {1}, Mass: {2}, memo-loss: {3}", name, color, mass, whereAmI);
        }
    }
}
