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
using Wanderer_V2._0.Model;
using Wanderer_V2._0.View;

namespace Wanderer_V2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int initial = 0;
        public MainWindow()
        {
            InitializeComponent();
            Screen.Columns = 10;
            Screen.Rows = 10;
           
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            var first = new Level(2);
            var Miki = new Hero();
            Miki.position = initial;

            if (e.Key == Key.Enter)
            {
                Display.DrawLevel(Screen, first);
                Display.DrawCharacter(Screen, Miki, first);
            }

            if (e.Key == Key.W)
            {
                Move.MoveUp(Screen, Miki, first);
            }

            if (e.Key == Key.A)
            {
                Move.MoveLeft(Screen, Miki, first);
            }

            if (e.Key == Key.S)
            {
                Move.MoveDown(Screen, Miki, first);
            }

            if (e.Key == Key.D)
            {
                Move.MoveRight(Screen, Miki, first);
            }

        }
    }
}
