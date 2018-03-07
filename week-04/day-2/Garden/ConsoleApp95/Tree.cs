using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp95
{
    public class Tree : Plant
    {
        public Tree(string color, int waterAmt):base(color, waterAmt)
        {

        }

        public string Status()
        {
            if (waterAmt < 10)
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
