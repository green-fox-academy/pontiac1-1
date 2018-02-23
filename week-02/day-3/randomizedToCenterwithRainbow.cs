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
using System;
using System.Windows.Controls;
using GreenFox;

namespace Drawing
{
    public partial class MainWindow : Window
    {

        public void takethepoints(double x, double y, Color z)
        {
                Random ctr = new Random();
                var tocenter = new FoxDraw(canvas);
                var start = new Point(x, y);
                var end = new Point(ctr.Next(0, 700), ctr.Next(0, 700));
                tocenter.StrokeColor(z);
                tocenter.DrawLine(start, end);
        }
        public MainWindow()
        {

            Color[] colores = { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet };

            InitializeComponent();
            var index = 0;
            for (int i = 0; i <= 700; i+=20)
            {
                takethepoints(i, i-i, colores[index]);
                takethepoints(i - i, i, colores[index]);
                takethepoints(Width, i, colores[index]);
                takethepoints(i, Width, colores[index]);
                index++;
                if (index == 7)
                {
                    index = 0;
                }
            }
        }

        //private void canvas_MouseMove(object sender, MouseEventArgs e)
        //{
        //    canvas.Children.Clear();
        //    end.X = e.GetPosition(canvas).X;
        //    end.Y = e.GetPosition(canvas).Y;
        //
        //    var index = 0;
        //    for (int i = 0; i <= 700; i += 20)
        //    {
        //        takethepoints(i, i - i, colores[index]);
        //        takethepoints(i - i, i, colores[index]);
        //        takethepoints(Width, i, colores[index]);
        //        takethepoints(i, Width, colores[index]);
        //        index++;
        //        if (index == 7)
        //        {
        //            index = 0;
        //        }
        //    }
        //
        //}
    }
}
