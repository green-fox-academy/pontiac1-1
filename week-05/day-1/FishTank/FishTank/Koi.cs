using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Koi : Fish
    {
        public Koi(string name, float mass, string color)
        {
            this.name = name;
            this.color = color;
            this.mass = mass;
        }

        public override float Feed()
        {
            mass += 2;
            return mass;
        }
    }
}
