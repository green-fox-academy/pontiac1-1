using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wanderer_V2._0.Model;
using Wanderer_V2._0.View;
using Wanderer_V2._0.Controls;

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
            Display.DrawMap(Screen);
            Display.Player1(Screen);
            Display.Monster(Screen);
            Controller.MoveMonster(200, Screen);
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                
            }

            if (e.Key == Key.W)
            {
                
            }

            if (e.Key == Key.A)
            {
                Controller.A(Screen);
                Controller.MoveMonster(120, Screen);

            }

            if (e.Key == Key.S)
            {
                
            }

            if (e.Key == Key.D)
            {
                Controller.D(Screen);

            }
        }
    }
}
