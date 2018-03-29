using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;

namespace Sudoku.Model
{
    class Values
    {
        public static List<ImageBrush> EnteredValues;
        public static List<int> lvlValues;

        public static void Fill()
        {
            lvlValues = new List<int>()
            {
                6, 0, 5, 0, 4, 0, 0, 7, 0,
                0, 0, 2, 0, 0, 0, 0, 6, 0,
                0, 0, 7, 8, 0, 0, 0, 3, 2,
                4, 0, 6, 3, 9, 0, 0, 0, 0,
                0, 8, 0, 0, 2, 0, 0, 9, 0,
                0, 0, 0, 0, 5, 4, 2, 0, 6,
                3, 7, 0, 0, 0, 5, 6, 0, 0,
                0, 5, 0, 0, 0, 0, 8, 0, 0,
                0, 6, 0, 0, 8, 0, 1, 0, 3
            };

            var empty = new Image();
            empty.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\0.png"));
            var brush = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\0.png")));
            EnteredValues = new List<ImageBrush>();

            for (int i = 0; i < 81; i++)
            {
                EnteredValues.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\"+lvlValues[i]+".png"))));
            }            
        }
    }
}
