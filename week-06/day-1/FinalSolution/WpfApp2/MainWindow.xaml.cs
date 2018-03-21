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

            string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\level1.txt";
            string wallOrFloor = File.ReadAllText(path);
            var floors = new List<int>();

            for (int i = 0; i < wallOrFloor.Length; i++)
            {
                if (wallOrFloor[i] == '0')
                {
                    floors.Add(i);
                }
            }

            var maxindex = floors.Count;
            var rnd = new Random();
            var rndPosition = rnd.Next(0, --maxindex);

            Draw.DrawMap(Map);
            Draw.DrawHero(Map, "herofront");
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                Controls.W(Map);
            }

            if (e.Key == Key.A)
            {
                Controls.A(Map);
            }

            if (e.Key == Key.S)
            {
                Controls.S(Map);
            }

            if (e.Key == Key.D)
            {
                Controls.D(Map);
            }
        }
    }
}
