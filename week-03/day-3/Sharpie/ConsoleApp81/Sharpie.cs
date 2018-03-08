using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    public class Sharpie
    {
        public string Color;
        public double Width;
        public double InkAmt;

        public Sharpie()
        {
            InkAmt = 100;
            Width = 0.5;
            Color = "inidgo";
        }

        public Sharpie(string Color, double Width, double InkAmt)
        {
            this.Color = Color;
            this.Width = Width;
            this.InkAmt = InkAmt;
        }
        public void use(string testWord)
        {
            for (int i = 0; i < testWord.Length; i++)
            {
                InkAmt--;
            }
        }
    }
}
