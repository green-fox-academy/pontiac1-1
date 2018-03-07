using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp95
{
    public class Flower : Plant
    {
        public Flower(string color, int waterAmt) : base(color, waterAmt)
        {

        }

        public string Status()
        {
            if (waterAmt < 5)
            {
                needsWataer = true;
                return "needs water? " + needsWataer;
            }
            else
            {
                needsWataer = false;
                return "needs water? " + needsWataer;
            }
        }
    }
}
