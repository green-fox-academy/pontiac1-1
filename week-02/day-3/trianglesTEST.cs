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
                var astart = new Point(0, Height);
                var aend = new Point(Width, Height);
                a.StrokeColor(Colors.Black);
                a.FillColor(Colors.Black);
                a.DrawLine(astart, aend);

                var b = new FoxDraw(canvas);
                var bstart = new Point(Width, Height);
                var bend = new Point((Width / 2), (Height - Math.Sqrt(270000)));
                b.StrokeColor(Colors.Black);
                b.FillColor(Colors.Black);
                b.DrawLine(bstart, bend);

                var c = new FoxDraw(canvas);
                var cstart = new Point((Width / 2), (Height - Math.Sqrt(270000)));
                var cend = new Point(0, Height);
                c.StrokeColor(Colors.Black);
                c.FillColor(Colors.Black);
                c.DrawLine(cstart, cend);

            var pointsOnA = new Point[20];
            var pointsOnB = new Point[20];
            var pointsOnC = new Point[20];
            int index = 0;
            for (int i = 30; i <= Width; i+=30)
                {

                pointsOnA[index] = new Point(i, Height);

                pointsOnB[index] = new Point(600-(i / 2), Height - Math.Sqrt((Math.Pow(i, 2) - Math.Pow((i / 2), 2))));

                pointsOnC[index] = new Point(0 + (i / 2), Height - Math.Sqrt((Math.Pow(i, 2) - Math.Pow((i / 2), 2))));
                index++;
                }

            //for (int i = 60; i < 61; i++)
            //{
            //
            //var g = new Point(60, Height);
            //var h = new Point(30, Height - Math.Sqrt((Math.Pow(i,2) - Math.Pow((i/2),2))));
            //var tester = new FoxDraw(canvas);
            //tester.DrawLine(g, h);
            //}

            int testindex = 18;
            for (int i = 0; i < 19; i++)
            {
                var test = new FoxDraw(canvas);
                test.DrawLine(pointsOnA[i], pointsOnC[i]);
                var test2 = new FoxDraw(canvas);
                test2.DrawLine(pointsOnB[i], pointsOnC[i]);
                var test3 = new FoxDraw(canvas);
                test2.DrawLine(pointsOnA[i], pointsOnB[testindex]);
                testindex--;


            }






        }
    }
}
