using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfApp2
{
    static class Hero
    {
        static public void DrawHero(System.Windows.Controls.Primitives.UniformGrid map, int position = 0)
        {
            int[] Cells = new int[100];
            for (int i = 0; i < 100; i++)
            {
                Cells[i] = i;
            }

            var hero = new Image();
            hero.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\WpfApp2\WpfApp2\Assets\hero-down.png"));
            map.Children.Clear();
            Map.DrawMap(map);
            map.Children.Insert(Cells[position], hero);
        }
    }
}
