using GreenFox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    static class DrawWalkable
    {
        static public void DrawFloor(FoxDraw a, double Width, double Height)
        {
        string path = @".\assets\floor.png";
            for (double x = 0; x < Width; x+=Width/10)
            {
                for (double y = 0; y<Height; y+= Height/10)
                {
                    a.AddImage(path, x, y);
                }
            }
        }
    }
}
