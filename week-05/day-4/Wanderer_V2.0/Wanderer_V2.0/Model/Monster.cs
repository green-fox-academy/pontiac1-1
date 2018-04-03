using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer_V2._0.Model
{
    class Monster : Character
    {
        public int lvl;
        public bool key;

        public Monster()
        {
            lvl = 1;
            var rnd = new Random();
            HP = 2 * lvl * rnd.Next(1, 6);
            DP = lvl / 2 * rnd.Next(1, 6);
            SP = lvl * rnd.Next(1, 6);
            uripath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-4\Wanderer_V2.0\Wanderer_V2.0\Assets\skeleton.png";
        }
    }
}
