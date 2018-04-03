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
        

        public static void Fill()
        {
            string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\level1.txt";
            int txtValues = int.Parse(File.ReadAllLines(path)[0][0].ToString());
            lvlValues = new List<List<int>>();
            for (int i = 0; i < 9; i++)
            {
                lvlValues.Add(new List<int>());
                for (int j = 0; j < 9; j++)
                {
                    lvlValues[i].Insert(j, int.Parse(File.ReadAllLines(path)[i][j].ToString()));
                }
            }
            
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
