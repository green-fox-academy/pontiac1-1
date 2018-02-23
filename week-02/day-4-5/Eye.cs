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
            var container = new FoxDraw(canvas);
            container.FillColor(Colors.Transparent);
            container.StrokeColor(Colors.Black);
            container.DrawRectangle(0, 0, 600, 600);


            var index = 0;
            for (int i = 15; i <= Width; i+=15)
            {
            var PointsOnA = new Point[600/i];
            var PointsOnB = new Point[600/i];
            var PointsOnC = new Point[600/i];
            var PointsOnD = new Point[600/i];

            PointsOnA[index] = new Point(i, Height);
            PointsOnB[index] = new Point(Width, Height - i);
            PointsOnC[index] = new Point(Width - i, 0);
            PointsOnD[index] = new Point(0, 0 + i);

            var linesOnLeft = new FoxDraw(canvas);
            var linesOnRight = new FoxDraw(canvas);
            linesOnLeft.DrawLine(PointsOnC[index], PointsOnD[index]);
            linesOnRight.DrawLine(PointsOnA[index], PointsOnB[index]);


            }
        }
    }
}
