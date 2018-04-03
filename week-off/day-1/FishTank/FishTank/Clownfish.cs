using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Clownfish : Fish
    {
        public Clownfish(string name, float mass, string color, string pattern)
        {
            this.name = name;
            this.color = color;
            this.pattern = pattern;
            this.mass = mass;
        }

    }
}
