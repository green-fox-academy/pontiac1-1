using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp80
{
    class Sharpie
    {
        public string Color;
        public double Width;
        public double InkAmt;

        public Sharpie(string Color, double Width, double InkAmt = 50)
        {
            this.Color = Color;
            this.Width = Width;
            this.InkAmt = InkAmt;
        }
        public void use()
        {
            InkAmt--;
        }
        



    }
}
