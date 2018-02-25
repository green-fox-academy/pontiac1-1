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

            var a = new FoxDraw(canvas);
            var astart = new Point(0, 600);
            var aend = new Point(600, 600);
            a.StrokeColor(Colors.Black);
            a.FillColor(Colors.Black);
            a.DrawLine(astart, aend);

            var b = new FoxDraw(canvas);
            var bstart = new Point(600, 600);
            var bend = new Point((600 / 2), (600 - Math.Sqrt((Math.Pow(600, 2)) - Math.Pow((600 / 2), 2))));
            b.StrokeColor(Colors.Black);
            b.FillColor(Colors.Black);
            b.DrawLine(bstart, bend);

            var c = new FoxDraw(canvas);
            var cstart = new Point((600 / 2), (600-Math.Sqrt((Math.Pow(600, 2) - Math.Pow((600 / 2), 2)))));
            var cend = new Point(0, 600);
            c.StrokeColor(Colors.Black);
            c.FillColor(Colors.Black);
            c.DrawLine(cstart, cend);

            var pointsOnA = new Point[40];
            var pointsOnB = new Point[40];
            var pointsOnC = new Point[40];
            int index = 0;
            for (int i = 15; i <= 600; i += 15)
            {
                pointsOnA[index] = new Point(i, Height);

                pointsOnB[index] = new Point(Width - (i / 2), Height - Math.Sqrt((Math.Pow(i, 2) - Math.Pow((i / 2), 2))));

                pointsOnC[index] = new Point(0 + (i / 2), Height - Math.Sqrt((Math.Pow(i, 2) - Math.Pow((i / 2), 2))));
                index++;
            }

            int testindex = 39;
            for (int i = 0; i < 40 - 1; i++)
            {
                var test = new FoxDraw(canvas);
                test.DrawLine(pointsOnA[testindex], pointsOnC[i]);
                var test2 = new FoxDraw(canvas);
                test2.DrawLine(pointsOnB[i], pointsOnC[testindex]);
                var test3 = new FoxDraw(canvas);
                test3.DrawLine(pointsOnA[i], pointsOnB[i]);
                testindex--;
            }
        }
