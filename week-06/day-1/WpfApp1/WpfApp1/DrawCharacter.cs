using GreenFox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    static class DrawCharacter
    {
        static public void DrawHero(FoxDraw a, double x, double y)
        {
            string path = @".\assets\hero-down.png";
            a.AddImage(path, x, y);
        }

        static public void DrawCover(FoxDraw a, double x, double y)
        {
            string path = @".\assets\floor.png";
            a.AddImage(path, x, y);
        }
    }
}

        
    

