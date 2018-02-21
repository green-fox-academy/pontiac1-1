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
            var foxDraw = new FoxDraw(canvas);
            foxDraw.StrokeColor(Colors.Red);
            var startPoint = new Point(200, 300);
            var endPoint = new Point(400, 300);
            foxDraw.DrawLine(startPoint, endPoint);


            var foxDraw2 = new FoxDraw(canvas);
            foxDraw2.StrokeColor(Colors.Green);
            var startPontforgreen = new Point(200, 310);
            var endPointforgreen = new Point(400, 310);
            foxDraw2.DrawLine(startPontforgreen, endPointforgreen);


            var Box1 = new FoxDraw(canvas);
            Box1.StrokeColor(Colors.Red);
            var start1 = new Point(200, 320);
            var end1 = new Point(400, 320);
            Box1.DrawLine(start1, end1);

            var Box2 = new FoxDraw(canvas);
            Box2.StrokeColor(Colors.Blue);
            var start2 = new Point(200, 320);
            var end2 = new Point(200, 520);
            Box2.DrawLine(start2, end2);

            var Box3 = new FoxDraw(canvas);
            Box3.StrokeColor(Colors.Black);
            var start3 = new Point(200, 520);
            var end3 = new Point(400, 520);
            Box3.DrawLine(start3, end3);

            var Box4 = new FoxDraw(canvas);
            Box4.StrokeColor(Colors.Green);
            var start4 = new Point(400, 520);
            var end4 = new Point(400, 320);
            Box4.DrawLine(start4, end4);



        }
    }
}
