using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Wanderer_V2._0.Model;

namespace Wanderer_V2._0.View
{
    public static class Move
    {
        public static void MoveUp(System.Windows.Controls.Primitives.UniformGrid screen, Character a, Level b)
        {
            a.position -= 10;
            var charactertile = new Image();
            charactertile.Source = new BitmapImage(new Uri(a.uripath));
            screen.Children.RemoveAt(a.position);
            screen.Children.Insert(a.position, charactertile);
        }

        public static void MoveLeft(System.Windows.Controls.Primitives.UniformGrid screen, Character a, Level b)
        {
            --a.position;
            var charactertile = new Image();
            charactertile.Source = new BitmapImage(new Uri(a.uripath));
            screen.Children.RemoveAt(a.position);
            screen.Children.Insert(a.position, charactertile);
        }

        public static void MoveDown(System.Windows.Controls.Primitives.UniformGrid screen, Character a, Level b)
        {
            a.position += 10;
            var charactertile = new Image();
            charactertile.Source = new BitmapImage(new Uri(a.uripath));
            screen.Children.RemoveAt(a.position);
            screen.Children.Insert(a.position, charactertile);
        }

        public static void MoveRight(System.Windows.Controls.Primitives.UniformGrid screen, Character a, Level b)
        {
            ++a.position;
            var charactertile = new Image();
            charactertile.Source = new BitmapImage(new Uri(a.uripath));
            screen.Children.RemoveAt(a.position);
            screen.Children.Insert(a.position, charactertile);
        }
    }
}
