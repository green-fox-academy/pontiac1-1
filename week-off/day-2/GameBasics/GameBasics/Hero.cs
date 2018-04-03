using System;
using System.Collections.Generic;
using System.Text;

namespace GameBasics
{
    class Hero : Character
    {
        string name;

        protected Hero(string name)
        {
            this.name = name;

            var rnd = new Random();
            HP = 20 + (3 * rnd.Next(1, 6));
            DP = 2 * rnd.Next(1, 6);
            SP = 5 * rnd.Next(1, 6);
        }
    }
}
