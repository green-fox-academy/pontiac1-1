using GreenFox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    static class Move
    {
        static public double MoveIt(FoxDraw a)
        {
            double x = 0;
            double y = 0;
            DrawCharacter.DrawHero(a, x, y);
            return x += 70;
        }
    }
}
