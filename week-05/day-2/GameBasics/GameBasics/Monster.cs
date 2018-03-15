using System;
using System.Collections.Generic;
using System.Text;

namespace GameBasics
{
    class Monster : Character
    {
        protected int lvl;

        public Monster(int lvl = 1)
        {
            this.lvl = lvl;

            var rnd = new Random();
            HP = 2 * lvl * rnd.Next(1, 6);
            DP = lvl / (2 * rnd.Next(1, 6));
            SP = lvl * rnd.Next(1, 6);
        }
    }
}
