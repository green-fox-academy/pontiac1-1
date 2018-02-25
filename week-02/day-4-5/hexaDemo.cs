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
            double indexY = 16;
            for (int i = 0; i < 7; i++)
            {
                drawhex(100, 100+indexY);
                indexY += 16;
            }
            double indexX = -14;
            indexY = 24;
            for (int i = 1; i < 13; i++)
            {
                if (i == 7)
                {
                    indexX = 14;
                    indexY = 24;
                }
                drawhex(100+indexX, 100 + indexY);
                indexY += 16;
            }
            indexX = -28;
            indexY = 32;
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    indexX = 28;
                    indexY = 32;
                }
                drawhex(100 + indexX, 100 + indexY);
                indexY += 16;
            }
            indexX = -42;
            indexY = 40;
            for (int i = 0; i < 8; i++)
            {
                if (i==4)
                {
                    indexX = 42;
                    indexY = 40;
                }
                drawhex(100 + indexX, 100 + indexY);
                indexY += 16;


            }


        }
        public void drawhex(double a, double b)
        {
            var PointsOfHex = new PointCollection();
            PointsOfHex.Add(new Point(a, b));
            PointsOfHex.Add(new Point(a + 10, b));
            PointsOfHex.Add(new Point(a + 14, b + 8));
            PointsOfHex.Add(new Point(a + 10, b + 16));
            PointsOfHex.Add(new Point(a, b + 16));
            PointsOfHex.Add(new Point(a - 4, b + 8));

            var Hex = new FoxDraw(canvas);
            Hex.FillColor(Colors.Transparent);
            Hex.DrawPolygon(PointsOfHex);
        }
    }
}
