using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Waves
{
    public class Display
    {
        public static void SineCurves(System.Windows.Controls.Canvas Board, System.Windows.Controls.Grid Screen)
        {

            var wave = new Polyline();
            wave.Stroke = Brushes.Black;
            wave.StrokeThickness = 1;
            double wavelenght1 = 340 / Values.ValueList[0];
            
            var wave2 = new Polyline();
            wave2.Stroke = Brushes.Black;
            wave2.StrokeThickness = 1;
            double wavelenght2 = 340 / Values.ValueList[1];

            for (Int32 x = 0; x <= Screen.Width; x += 1)
            {
                Point sin1 = new Point(x, Screen.Height / 2 + Screen.Height / 2 * Math.Sin(x / (wavelenght1 * Math.PI)));
                Point sin2 = new Point(x, Screen.Height / 2 + Screen.Height / 2 * Math.Sin(x / (wavelenght2 * Math.PI)));
                wave.Points.Add(sin1);
                wave2.Points.Add(sin2);
            }
            Screen.Children.Add(wave);
            Screen.Children.Add(wave2);
        }
    }
}
