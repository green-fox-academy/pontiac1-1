using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer_V2._0.Model
{
    public class Hero : Character
    {
        public Hero()
        {
            var rnd = new Random();
            HP = 20 + (3 * rnd.Next(1, 6));
            DP = 2 * rnd.Next(1, 6);
            SP = 5 + rnd.Next(1, 6);
            uripath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-4\Wanderer_V2.0\Wanderer_V2.0\Assets\xwingup.jpg";

        }
    }
}
