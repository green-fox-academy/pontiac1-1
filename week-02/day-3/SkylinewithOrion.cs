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
            var background = new FoxDraw(canvas);
            background.FillColor(Colors.Black);
            background.DrawRectangle(0, 0, 700, 700);


            Random generalrandom = new Random();
            double numofstars = generalrandom.Next(300, 500);
            Color[] starcolors = { Colors.Wheat, Colors.LightBlue, Colors.LightGoldenrodYellow, Colors.LightYellow };
            for (int i = 0; i <= numofstars; i++)
            {
                InitializeComponent();

                double sizex = generalrandom.Next(1, 3);
                double sizey = sizex;
                double posx = generalrandom.Next(0, 700);
                double posy = generalrandom.Next(0, 700);

                var star = new FoxDraw(canvas);
                star.FillColor(starcolors[generalrandom.Next(0, starcolors.Length - 1)]);
                star.StrokeColor(Colors.White);
                star.DrawEllipse(posx, posy, sizex, sizey);
            }

            int transOrionx = generalrandom.Next(0, 700);
            int transOriony = generalrandom.Next(0, 700);
            Orion(transOrionx, transOriony, starcolors[generalrandom.Next(0, starcolors.Length-1)]);
        }

        public void Orion(int x, int y, Color z) {
            InitializeComponent();

            var orionHead = new FoxDraw(canvas);
            orionHead.FillColor(z);
            orionHead.StrokeColor(Colors.White);
            orionHead.DrawEllipse(30+x, 0+y, 2, 2);

            var orionRightShoulder = new FoxDraw(canvas);
            orionRightShoulder.FillColor(z);
            orionRightShoulder.StrokeColor(Colors.White);
            orionRightShoulder.DrawEllipse(0+x, 10+y, 3, 3);

            var orionLeftShoulder = new FoxDraw(canvas);
            orionLeftShoulder.FillColor(z);
            orionLeftShoulder.StrokeColor(Colors.White);
            orionLeftShoulder.DrawEllipse(40+x, 18+y, 2, 2);

            var orionUppermost = new FoxDraw(canvas);
            orionUppermost.FillColor(z);
            orionUppermost.StrokeColor(Colors.White);
            orionUppermost.DrawEllipse(0+x, 0+y, 2, 2);

            var orionBeltLeft = new FoxDraw(canvas);
            orionBeltLeft.FillColor(z);
            orionBeltLeft.StrokeColor(Colors.White);
            orionBeltLeft.DrawEllipse(30+x, 45+y, 2, 2);

            var orionBeltMiddle = new FoxDraw(canvas);
            orionBeltMiddle.FillColor(z);
            orionBeltMiddle.StrokeColor(Colors.White);
            orionBeltMiddle.DrawEllipse(25+x, 47+y, 3, 3);

            var orionBeltRight = new FoxDraw(canvas);
            orionBeltRight.FillColor(z);
            orionBeltRight.StrokeColor(Colors.White);
            orionBeltRight.DrawEllipse(20+x, 49+y, 3, 3);

            var orionLeftLeg = new FoxDraw(canvas);
            orionLeftLeg.FillColor(z);
            orionLeftLeg.StrokeColor(Colors.White);
            orionLeftLeg.DrawEllipse(46+x, 70+y, 2, 2);

            var orionRightLeg = new FoxDraw(canvas);
            orionRightLeg.FillColor(z);
            orionRightLeg.StrokeColor(Colors.White);
            orionRightLeg.DrawEllipse(10+x, 76+y, 3, 3);

            var orionBowUppermost = new FoxDraw(canvas);
            orionBowUppermost.FillColor(z);
            orionBowUppermost.StrokeColor(Colors.White);
            orionBowUppermost.DrawEllipse(70+x, 0+y, 2, 2);

            var orionTop = new FoxDraw(canvas);
            orionTop.FillColor(z);
            orionTop.StrokeColor(Colors.White);
            orionTop.DrawEllipse(72+x, 8+y, 2, 2);

            var orionMiddle = new FoxDraw(canvas);
            orionMiddle.FillColor(z);
            orionMiddle.StrokeColor(Colors.White);
            orionMiddle.DrawEllipse(73+x, 12+y, 2, 2);

            var orionBottom = new FoxDraw(canvas);
            orionBottom.FillColor(z);
            orionBottom.StrokeColor(Colors.White);
            orionBottom.DrawEllipse(72+x, 16+y, 2, 2);

            var orionBottomM = new FoxDraw(canvas);
            orionBottomM.FillColor(z);
            orionBottomM.StrokeColor(Colors.White);
            orionBottomM.DrawEllipse(70+x, 20+y, 3, 3);
        }
        public void Constillations()
        {

        }

    }
}
