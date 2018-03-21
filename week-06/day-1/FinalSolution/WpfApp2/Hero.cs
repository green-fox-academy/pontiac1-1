using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    static class Hero
    {
        static public void DrawHero(System.Windows.Controls.Primitives.UniformGrid map, string pose, int position = 0)
        {
            int[] Cells = new int[100];
            for (int i = 0; i < 100; i++)
            {
                Cells[i] = i;
            }
            var charactertile = new Rectangle();
            var hero = new Image();
            string uripath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\"+pose+".png";
            hero.Source = new BitmapImage(new Uri(uripath));
            map.Children.Clear();
            Map.DrawMap(map);
            var characterbrush = new ImageBrush(hero.Source);
            charactertile.Fill = characterbrush;
            map.Children.RemoveAt(Cells[position]);
            map.Children.Insert(Cells[position], charactertile);    
        }
    }
}
