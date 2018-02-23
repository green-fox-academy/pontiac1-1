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


namespace Drawing
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var Top = new Point(Width / 2, 0);
            var Rigth = new Point(Width, Height / 2);
            var Bottom = new Point(Width / 2, Height);
            var Left = new Point(0, Height / 2);
            var Center = new Point(Width / 2, Height / 2);

            for (int i = 5; i < Width/2; i+=5)
            {
                var bottomRigth = new FoxDraw(canvas);
                var bottomLeft = new FoxDraw(canvas);
                var topRigth = new FoxDraw(canvas);
                var topLeft = new FoxDraw(canvas);
                bottomRigth.DrawLine(new Point(Width / 2,(Height / 2)+i), new Point(Width-i, Height / 2));
                bottomLeft.DrawLine(new Point(Width / 2, (Height / 2) + i), new Point(0+i, Height / 2));
                topRigth.DrawLine(new Point(Width / 2, (Height / 2) - i), new Point(Width - i, Height / 2));
                topLeft.DrawLine(new Point(Width / 2, (Height / 2) - i), new Point(0+ i, Height / 2));
            }
            var cheatRtoL = new FoxDraw(canvas);
            cheatRtoL.DrawLine(Left, Rigth);
            var cheatTtoB = new FoxDraw(canvas);
            cheatTtoB.DrawLine(Top, Bottom);
        }
    }
}
