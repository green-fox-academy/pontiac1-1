using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wanderer_V2._0.Model;

namespace Wanderer_V2._0.View
{
    public static class Display
    {
        public static void DrawLevel(System.Windows.Controls.Primitives.UniformGrid screen, Level a)
        {

            var boxes = new List<int>();

            //getting the index num of walls
            for (int i = 0; i < a.levelContent.Length; i++)
            {
                if (a.levelContent[i] == '1')
                {
                    boxes.Add(i);
                }
            }

            //adding the walls
            for (int j = 0; j < 100; j++)
            {
                if (boxes.Contains(j))
                {
                    var boxtile = new Image();
                    boxtile.Source = new BitmapImage(new Uri(a.uripath));
                    screen.Children.Add(boxtile);
                }
                else
                {
                    var tile = new Rectangle();
                    screen.Children.Add(tile);
                }
            }
        }

        public static void DrawCharacter(System.Windows.Controls.Primitives.UniformGrid screen, Character a, Level b)
        {
            var charactertile = new Image();
            charactertile.Source = new BitmapImage(new Uri(a.uripath));
            screen.Children.Clear();
            DrawLevel(screen, b);
            screen.Children.RemoveAt(a.position);
            screen.Children.Insert(a.position, charactertile);
        }

        public static void DeleteCharacter(System.Windows.Controls.Primitives.UniformGrid screen, Character a)
        {
            screen.Children.RemoveAt(a.position);
        }
    }
}
