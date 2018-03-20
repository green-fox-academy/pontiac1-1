using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace WpfApp2
{
    static class Map
    {
        static public void DrawMap(System.Windows.Controls.Primitives.UniformGrid map)
        {
            string levelPath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\WpfApp2\WpfApp2\Assets\level1.txt";
            string level = File.ReadAllText(levelPath);
            
            for (int i = 0; i < 100; i++)
            {
                    var tile = new Rectangle();
                    map.Children.Add(tile);

                    var floor = new Image();
                    floor.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\WpfApp2\WpfApp2\Assets\floor.png"));
                    var floorbrush = new ImageBrush(floor.Source);

                    var wall = new Image();
                    wall.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\WpfApp2\WpfApp2\Assets\wall.png"));
                    var wallbrush = new ImageBrush(wall.Source);


                if (level[i] == '0')
                {
                    tile.Fill = floorbrush;
                }

                else
                {
                    tile.Fill = wallbrush;
                }
            }
        }
    }
}
