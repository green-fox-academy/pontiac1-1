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
            lvlValues.Add(new List<int> { 0, 0, 0, 0, 0, 2, 3, 1, 0 });
            lvlValues.Add(new List<int> { 2, 0, 0, 4, 0, 0, 0, 0, 0 });
            lvlValues.Add(new List<int> { 5, 9, 0, 6, 8, 0, 0, 7, 4 });
            lvlValues.Add(new List<int> { 6, 5, 8, 9, 0, 7, 0, 2, 0 });
            lvlValues.Add(new List<int> { 0, 7, 0, 0, 0, 0, 0, 6, 0 });
            lvlValues.Add(new List<int> { 0, 2, 0, 3, 0, 6, 7, 8, 1 });
            lvlValues.Add(new List<int> { 9, 6, 0, 0, 7, 3, 0, 5, 2 });
            lvlValues.Add(new List<int> { 0, 0, 0, 0, 0, 9, 0, 0, 8 });
            lvlValues.Add(new List<int> { 0, 8, 2, 5, 0, 0, 0, 0, 0 });

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
