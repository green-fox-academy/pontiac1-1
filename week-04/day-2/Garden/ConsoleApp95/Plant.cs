using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp95
{
    public class Plant
    {
        public double waterAmt;
        public bool needsWataer;
        public string color;

        public Plant(string color, int waterAmt = 100)
        {
            this.color = color;
            this.waterAmt = waterAmt;
        }
    }
}
