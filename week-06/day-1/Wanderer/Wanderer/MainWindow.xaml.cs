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
using GreenFox;

namespace Wanderer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int columnWidth;
        private int rowHeight;
        private object canvas;

        public MainWindow()
        {
            InitializeComponent();
            Map.Columns = 10;
            Map.Rows = 10;

            for (int i = 0; i < 100; i++)
            {
                Image floor = new Image();
                floor.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\wanderer-cs\img\floor.png"));
                ImageBrush Floor = new ImageBrush(floor.Source);
                var walkable = new Rectangle();
                Map.Children.Add(walkable);
                walkable.Fill = Floor;
            }

            var nemtom = new FoxDraw(Map);
            nemtom.AddImage

            
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {

        }
    }

}
