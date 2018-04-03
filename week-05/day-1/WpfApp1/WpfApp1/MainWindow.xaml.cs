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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public Point pos = new Point(0, 0);
        public MainWindow()
        {
            InitializeComponent();
            var Map = new FoxDraw(canvas);
            DrawWalkable.DrawFloor(Map, Width, Height);
            //DrawCharacter.Character(Map, 0, 0);
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            var Map = new FoxDraw(canvas);
              
            if (e.Key == Key.W)
            {
                pos.Y -= 70;
                DrawCharacter.DrawHero(Map, pos.X, pos.Y);
                DrawCharacter.DrawCover(Map, pos.X, pos.Y+70);

            }

            if (e.Key == Key.A)
            {
                pos.X -= 70;
                DrawCharacter.DrawHero(Map, pos.X, pos.Y);
                DrawCharacter.DrawCover(Map, pos.X + 70, pos.Y);
            }

            if (e.Key == Key.S)
            {
                pos.Y += 70;
                DrawCharacter.DrawHero(Map, pos.X, pos.Y);
                DrawCharacter.DrawCover(Map, pos.X, pos.Y-70);
            }

            if (e.Key == Key.D)
            {
                pos.X += 70;
                DrawCharacter.DrawHero(Map, pos.X, pos.Y);
                DrawCharacter.DrawCover(Map, pos.X-70, pos.Y);
            }
        }
    }
}
