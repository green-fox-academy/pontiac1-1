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

namespace Game
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
                var walkable = new Rectangle();
                SolidColorBrush black = new SolidColorBrush(Colors.Black);
                black.Opacity = 0.4;
                walkable.StrokeThickness = 0.4;
                walkable.Stroke = black;
                Map.Children.Add(walkable);

                if (i == 1)
                {
                    Image xwing = new Image();
                    xwing.Source = new BitmapImage(new Uri(@"C:\Users\Test\Pictures\xwing.jpg"));
                    ImageBrush back = new ImageBrush(xwing.Source);
                    walkable.Fill = back;
                }
            }
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                Console.WriteLine("To the left!");
            }
        }
    }
}