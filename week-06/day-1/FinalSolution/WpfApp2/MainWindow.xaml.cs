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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int position = 0;
        public MainWindow()
        {
            InitializeComponent();
            Map.Columns = 10;
            Map.Rows = 10;

            for (int i = 0; i < 100; i++)
            {
                var floor = new Image();
                floor.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\WpfApp2\WpfApp2\Assets\floor.png"));
                var floorbrush = new ImageBrush(floor.Source);
                var tile = new Rectangle();
                tile.Fill = floorbrush;
                Map.Children.Add(tile);
            }

            Hero.DrawHero(Map);
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.W)
            {
                Hero.DrawHero(Map, position -= 10);
            }

            if (e.Key == Key.A)
            {
                Hero.DrawHero(Map, position--);
            }

            if (e.Key == Key.S)
            {
                Hero.DrawHero(Map, position += 10);
            }

            if (e.Key == Key.D)
            {
                Hero.DrawHero(Map, position++);
            }
        }
    }
}
