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
        public static List<List<int>> lvlValues;
        public static Dictionary<int, int> Inter;

        public static void Fill()
        {
            lvlValues = new List<List<int>>();
            lvlValues.Add(new List<int> { 8, 2, 4, 9, 5, 3, 6, 7, 1 });
            lvlValues.Add(new List<int> { 6, 3, 5, 8, 1, 7, 9, 2, 4 });
            lvlValues.Add(new List<int> { 7, 1, 9, 6, 2, 4, 8, 5, 3 });
            lvlValues.Add(new List<int> { 5, 8, 7, 2, 9, 1, 3, 4, 6 });
            lvlValues.Add(new List<int> { 1, 4, 2, 7, 3, 6, 5, 8, 9 });
            lvlValues.Add(new List<int> { 3, 9, 6, 4, 8, 5, 2, 1, 7 });
            lvlValues.Add(new List<int> { 2, 6, 1, 5, 4, 9, 7, 3, 8 });
            lvlValues.Add(new List<int> { 4, 7, 8, 3, 6, 2, 1, 9, 5 });
            lvlValues.Add(new List<int> { 9, 5, 3, 1, 7, 8, 0, 6, 2 });

            //for (int i = 0; i < 9; i+=9)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        Inter.Add(i * 9 + j, 'i'+'j');
            //    }
            //}

            var empty = new Image();
            empty.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\0.png"));
            var brush = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\0.png")));
            EnteredValues = new List<ImageBrush>();

            for (int i = 0; i < 81; i++)
            {
                EnteredValues.Add(new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\"+lvlValues[i/9][i%9]+".png"))));
            }            
        }
    }
}
