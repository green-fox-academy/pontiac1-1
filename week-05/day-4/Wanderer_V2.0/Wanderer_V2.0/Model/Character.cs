using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer_V2._0.Model
{
    public class Character
    {
        public string orient;
        public int position;
        public int HP;
        public int DP;
        public int SP;
        public string uripath;

        public void Move(Character a, int change)
        {
            a.position += change;
        }
    }
}
