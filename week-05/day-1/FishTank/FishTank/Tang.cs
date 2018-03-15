using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Tang : Fish
    {
        public Tang(string name, float mass,  string color, bool whereAmI)
        {
            this.name = name;
            this.color = color;
            this.mass = mass;
            this.whereAmI = whereAmI;
        }
    }
}
