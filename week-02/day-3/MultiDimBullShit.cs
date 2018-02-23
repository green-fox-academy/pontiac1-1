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
        public MainWindow()
        {
            InitializeComponent();

            double[][,] pointsArray = new double[3][,]
            {
                new double[,] {{ (Width / 2) }, { 100 } },
                new double[,] {{ (Width / 2) - 4 }, { 108 } },
                new double[,] {{ (Width / 2) + 4 }, { 108 } }
            };

            var foxDraw = new FoxDraw(canvas);
            var x = new Point(pointsArray[0][0, 0], pointsArray[0][1,0]);
            var y = new Point(pointsArray[1][0, 0], pointsArray[1][1, 0]);
            var z = new Point(pointsArray[2][0, 0], pointsArray[2][1, 0]);

            var pointsoftri = new PointCollection();
            pointsoftri.Add(x);
            pointsoftri.Add(y);
            pointsoftri.Add(z);


            Point[] zPoints = new Point[] { };
            var tri = new FoxDraw(canvas);
            tri.StrokeColor(Colors.Red);
            tri.FillColor(Colors.Transparent);
            tri.DrawPolygon(pointsoftri);

            for (int i = 2; i < pointsoftri.Count; i += 2)
            {
                zPoints = new Point[] { pointsoftri[i] };
            }


            foreach (var item in zPoints)
            {

                var j = new Point(pointsArray[2][0, 0], pointsArray[2][1, 0]);
                pointsoftri.Add(j);


            }



        }
    }
}
