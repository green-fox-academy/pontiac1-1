using GreenFox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Map.Columns = 10;
            Map.Rows = 10;

            //for (int i = 0; i < 100; i++)
            //{
            //    var floor = new Image();
            //    floor.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\floor.png"));
            //    var floorbrush = new ImageBrush(floor.Source);
            //    var tile = new Rectangle();
            //    //tile.Fill = floorbrush;
            //    Map.Children.Add(tile);
            //}

            Draw.DrawMap(Map);
            Draw.DrawHero(Map, "herofront");
            Draw.DrawMonster(Map);

        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            //reading level.txt to get index of walls
            //string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\level1.txt";
            //string wallOrFloor = File.ReadAllText(path);
            //var walls = new List<int>();
            //int index = position;
            //for (int i = 0; i < wallOrFloor.Length; i++)
            //{
            //    if (wallOrFloor[i] == '1')
            //    {
            //        walls.Add(i);
            //    }
            //}

            //controls
            if (e.Key == Key.W)
            {
                Controls.W(Map);
                //try
                //{
                //    if (!walls.Contains(index -= 10))
                //    {
                //        position -= 10;
                //        Hero.DrawHero(Map, "heroback", position);
                //    }
                //    else
                //    {
                //        Hero.DrawHero(Map, "heroback", position);
                //    }
                //}
                //catch (IndexOutOfRangeException)
                //{
                //    position += 10;
                //    Hero.DrawHero(Map, "heroback", position);
                //}        
            }

            if (e.Key == Key.A)
            {
                Controls.A(Map);
                //if (position % 10 != 0)
                //{
                //    if (!walls.Contains(--index))
                //    {
                //        Hero.DrawHero(Map, "heroleft", --position);
                //    }
                //    else
                //    {
                //        Hero.DrawHero(Map, "heroleft", position);
                //    }
                //}
                //else
                //{
                //    Hero.DrawHero(Map, "heroleft", position);
                //}
            }

            if (e.Key == Key.S)
            {
                Controls.S(Map);
                //try
                //{
                //    if (!walls.Contains(index += 10))
                //    {
                //        position += 10;
                //        Hero.DrawHero(Map, "herofront", position);
                //    }
                //    else
                //    {
                //        Hero.DrawHero(Map, "herofront", position);
                //    }
                //}
                //catch (IndexOutOfRangeException)
                //{
                //    position -= 10;
                //    Hero.DrawHero(Map, "herofront", position);
                //}
            }

            if (e.Key == Key.D)
            {
                Controls.D(Map);
                //if (position % 10 !=9)
                //{
                //    if (!walls.Contains(++index))
                //    {
                //        Hero.DrawHero(Map, "heroright", ++position);
                //    }
                //    else
                //    {
                //        Hero.DrawHero(Map, "heroright", position);
                //    }
                //}
                //else
                //{
                //    Hero.DrawHero(Map, "heroright", position);
                //}
            }
        }
    }
}
