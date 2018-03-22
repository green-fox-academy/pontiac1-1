using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace WpfApp2
{
    static class Draw
    {
        //static int position;
        public static void DrawMap(System.Windows.Controls.Primitives.UniformGrid map)
        {
            string levelPath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\level1.txt";
            string level = File.ReadAllText(levelPath);
            var floors = new List<int>();
            var walls = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (level[i] == '0')
                {
                    var tile = new Rectangle();
                    map.Children.Add(tile);
                    var floor = new Image();
                    floor.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\floor.png"));
                    var floorbrush = new ImageBrush(floor.Source);
                    tile.Fill = floorbrush;
                    floors.Add(i);
                }

                else
                {
                    var walltile = new Rectangle();
                    map.Children.Add(walltile);
                    var wall = new Image();
                    wall.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\wall.png"));
                    var wallbrush = new ImageBrush(wall.Source);
                    walltile.Fill = wallbrush;
                    walls.Add(i);
                }
            }
        }

        public static void DrawHero(System.Windows.Controls.Primitives.UniformGrid map, string pose, int position = 0)
        {
            int[] Cells = new int[100];
            for (int i = 0; i < 100; i++)
            {
                Cells[i] = i;
            }

            
            var charactertile = new Rectangle();
            var hero = new Image();
            string uripath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\" + pose + ".png";
            hero.Source = new BitmapImage(new Uri(uripath));
            map.Children.Clear();
            DrawMap(map);
            var characterbrush = new ImageBrush(hero.Source);
            charactertile.Fill = characterbrush;
            map.Children.RemoveAt(Cells[position]);
            map.Children.Insert(Cells[position], charactertile);
        }


        public static void DrawMonster(System.Windows.Controls.Primitives.UniformGrid map, int position)
        {
            string levelPath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\level1.txt";
            string level = File.ReadAllText(levelPath);
            var walkable = new List<int>();
            for (int i = 0; i < level.Length; i++)
            {
                if (level[i] == '0')
                {
                    walkable.Add(i);
                }
            }

            int up = position - 10;
            int down = position + 10;
            int left = position - 1;
            int right = position + 1;
            var moves = new List<int>();
            moves.Add(up);
            moves.Add(down);
            moves.Add(left);
            moves.Add(right);

            var available = new List<int>();
            for (int i = 0; i < moves.Count; i++)
            {
                if (walkable.Contains(moves[i]))
                {
                    available.Add(moves[i]);
                }
            }

            var rnd = new Random();
            int moveIndex = rnd.Next(0, available.Count);

            var monstertile = new Rectangle();
            var monster = new Image();
            string uripath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\monster.png";
            monster.Source = new BitmapImage(new Uri(uripath));
            var monsterbrush = new ImageBrush(monster.Source);
            monstertile.Fill = monsterbrush;
            map.Children.RemoveAt(available[moveIndex]);
            map.Children.Insert(available[moveIndex], monstertile);
        }
    }
}
