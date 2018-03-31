using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Sudoku.Model
{
    class Evaluate
    {
        public static void Check(System.Windows.Controls.Primitives.UniformGrid board)
        {
            //check for columns
            int columnCheck = 0;
            for (int i = 0; i < Values.lvlValues.Count; i++)
            {
            var tempColumn = new List<int>();
                for (int j = 0; j < Values.lvlValues.Count; j++)
                {
                    tempColumn.Add(Values.lvlValues[j][i]);
                }
                if (tempColumn.Distinct().Count() == 9)
                {
                    ++columnCheck;
                }
                else
                {
                    break;
                }
            }

            //check for rows
            int rowCheck = 0;
            for (int i = 0; i < Values.lvlValues.Count; i++)
            {
            var tempRow = new List<int>();
                for (int j = 0; j < Values.lvlValues.Count; j++)
                {
                    tempRow.Add(Values.lvlValues[i][j]);
                }
                if (tempRow.Distinct().Count() == 9)
                {
                    ++rowCheck;
                }
                else
                {
                    break;
                }
            }

            //check for tables
            int tableCheck = 0;
            for (int columnIndex = 0; columnIndex < 9; columnIndex += 3)
            {
                for (int rowIndex = 0; rowIndex < 9; rowIndex += 3)
                {
                    var tempTable = new List<int>();
                    for (int i = columnIndex; i < 3 + columnIndex; i++)
                    {
                        for (int j = rowIndex; j < 3 + rowIndex; j++)
                        {
                            tempTable.Add(Values.lvlValues[i][j]);
                        }
                    }
                    if (tempTable.Distinct().Count() == 9)
                    {
                        ++tableCheck;
                    }
                    else
                    {
                        break;
                    }
                }
            }
           
            if (rowCheck == 9 || columnCheck == 9 || tableCheck == 9)
            {
                board.Children.Clear();
                var green = new Rectangle();
                green.Fill = Brushes.Green;
                board.Children.Add(green);
            }
            else
            {
                board.Children.Clear();
                var red = new Rectangle();
                red.Fill = Brushes.Red;
                board.Children.Add(red);
            }
        }
    }
}
