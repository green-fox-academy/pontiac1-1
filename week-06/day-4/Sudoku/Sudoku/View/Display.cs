using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Sudoku.Model;

namespace Sudoku.View
{
    class Display
    {
        public static int position = 0;

        public static void Outline(Rectangle a)
        {
            a.Stroke = Brushes.Red;
            a.StrokeThickness = 3;
        }

        public static void DrawTable(System.Windows.Controls.Canvas table, System.Windows.Window main)
        {
            table.Width = main.Width;
            table.Height = main.Height;

            var border = new Rectangle();
            border.Stroke = Brushes.Black;
            border.StrokeThickness = 2;
            border.Width = main.Width;
            border.Height = main.Height;
            table.Children.Add(border);

            var line1 = new Line();
            line1.Stroke = Brushes.Black;
            line1.StrokeThickness = 2;

            line1.X1 = main.Width / 3;
            line1.Y1 = 0;
            line1.X2 = main.Width / 3;
            line1.Y2 = main.Height;
            table.Children.Add(line1);

            var line2 = new Line();
            line2.Stroke = Brushes.Black;
            line2.StrokeThickness = 2;

            line2.X1 = 2 * main.Width / 3;
            line2.Y1 = 0;
            line2.X2 = 2 * main.Width / 3;
            line2.Y2 = main.Height;
            table.Children.Add(line2);

            var line3 = new Line();
            line3.Stroke = Brushes.Black;
            line3.StrokeThickness = 2;

            line3.X1 = 0;
            line3.Y1 = main.Height / 3;
            line3.X2 = main.Width;
            line3.Y2 = main.Height / 3;
            table.Children.Add(line3);

            var line4 = new Line();
            line4.Stroke = Brushes.Black;
            line4.StrokeThickness = 2;

            line4.X1 = 0;
            line4.Y1 = 2 * main.Height / 3;
            line4.X2 = main.Width;
            line4.Y2 = 2 * main.Height / 3;
            table.Children.Add(line4);           

        }
        public static void DrawBoard(System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            board.Children.Clear();
            board.Columns = 9;
            board.Rows = 9;
            board.Width = main.Width;
            board.Height = main.Width;

            for (int i = 0; i < 81; i++)
            {
            
                var Cell = new Rectangle();
                Cell.Fill = Values.EnteredValues[i];

                if (i == position)
                {
                    Outline(Cell);

                }
                else
                {
                    Cell.Stroke = Brushes.Black;
                    Cell.StrokeThickness = 0.3;                   
                }

                board.Children.Add(Cell);              
            }
        }
    }
}
