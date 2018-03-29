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

        public static void DrawBoard(System.Windows.Controls.Primitives.UniformGrid board)
        {
            board.Children.Clear();
            board.Columns = 9;
            board.Rows = 9;

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
                    Cell.StrokeThickness = 1;                   
                }


                board.Children.Add(Cell);              
            }
        }
    }
}
