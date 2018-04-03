using System;
using System.Collections.Generic;
using System.Text;

namespace GameBasics
{
    class Boss : Monster
    {
        public Boss(int lvl = 10)
        {
            this.lvl = lvl;

            var rnd = new Random();
            HP = 2 * lvl * rnd.Next(1, 6) + rnd.Next(1, 6);
            DP = lvl / (2 * rnd.Next(1, 6)) + (rnd.Next(1, 6) / 2);
            SP = lvl * rnd.Next(1, 6) + lvl;
        }
    }
}
