using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wanderer_V2._0.Model;
using System.IO;

namespace Wanderer_V2._0.View
{
    public static class Display
    {
        public static void DrawMap(System.Windows.Controls.Primitives.UniformGrid screen)
        {
            screen.Rows = 12;
            screen.Columns = 20;

            string[] layout = File.ReadAllLines(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-4\Wanderer_V2.0\Wanderer_V2.0\Assets\levels\level_1.txt");


            for (int i = 0; i < layout.Length; i++)
            {
                for (int j = 0; j < layout[i].Length; j++)
                {
                    if (layout[i][j] == '0')
                    {
                        var air = new Rectangle();
                        screen.Children.Add(air);
                    }
                    else
                    {
                        var floortile = new Rectangle();
                        var floor = new Image();
                        floor.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-4\Wanderer_V2.0\Wanderer_V2.0\Assets\floor.jpg"));
                        var floorbrush = new ImageBrush();
                        floorbrush.ImageSource = floor.Source;
                        floortile.Fill = floorbrush;
                        screen.Children.Add(floortile);
                    }
                }
            }
        }

        public static void Player1(System.Windows.Controls.Primitives.UniformGrid screen, int position = 200, string pose = "heroright")
        {
            var hero = new Image();
            hero.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-4\Wanderer_V2.0\Wanderer_V2.0\Assets\" + pose + ".png"));
            screen.Children.Clear();
            DrawMap(screen);
            screen.Children.RemoveAt(position);
            screen.Children.Insert(position, hero);
        }

        public static void Monster(System.Windows.Controls.Primitives.UniformGrid screen, int position = 219, string pose = "heroleft")
        {
            var hero2 = new Image();
            hero2.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-4\Wanderer_V2.0\Wanderer_V2.0\Assets\boss.png"));
            DrawMap(screen);
            screen.Children.RemoveAt(position);
            screen.Children.Insert(position, hero2);
        }
    }
}
