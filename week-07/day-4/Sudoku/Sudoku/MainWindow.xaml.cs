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
using Sudoku.View;
using Sudoku.Controls;
using Sudoku.Model;

namespace Sudoku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Values.Fill();
            Display.DrawBoard(Board);
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                Controller.W(Board);
            }

            if (e.Key == Key.A)
            {
                Controller.A(Board);
            }

            if (e.Key == Key.S)
            {
                Controller.S(Board);
            }

            if (e.Key == Key.D)
            {
                Controller.D(Board);
            }

            //To enter Values
            if (e.Key == Key.NumPad1)
            {
                Controller.One(Display.position, Board);
            }

            if (e.Key == Key.NumPad2)
            {
                Controller.Two(Display.position, Board);
            }

            if (e.Key == Key.NumPad3)
            {
                Controller.Three(Display.position, Board);
            }

            if (e.Key == Key.NumPad4)
            {
                Controller.Four(Display.position, Board);
            }

            if (e.Key == Key.NumPad5)
            {
                Controller.Five(Display.position, Board);
            }

            if (e.Key == Key.NumPad6)
            {
                Controller.Six(Display.position, Board);
            }

            if (e.Key == Key.NumPad7)
            {
                Controller.Seven(Display.position, Board);
            }

            if (e.Key == Key.NumPad8)
            {
                Controller.Eight(Display.position, Board);
            }

            if (e.Key == Key.NumPad9)
            {
                Controller.Nine(Display.position, Board);
            }

            if (e.Key == Key.Back)
            {
                Controller.Delete(Display.position, Board);
            }
        }
    }
}
