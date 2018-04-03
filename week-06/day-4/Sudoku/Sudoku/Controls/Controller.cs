using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sudoku.View;
using Sudoku.Model;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace Sudoku.Controls
{
    class Controller
    {
        public static void W(System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var border = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                border.Add(i);
            }

            if (!border.Contains(Display.position))
            {
                Display.position -= 9;
                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        public static void A(System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var border = new List<int>();
            for (int i = 0; i < 81; i += 9)
            {
                border.Add(i);
            }

            if (!border.Contains(Display.position))
            {
                --Display.position;
                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        public static void S(System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var border = new List<int>();
            for (int i = 72; i < 81; i++)
            {
                border.Add(i);
            }

            if (!border.Contains(Display.position))
            {
                Display.position += 9;
                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        public static void D(System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var border = new List<int>();
            for (int i = 8; i < 81; i += 9)
            {
                border.Add(i);
            }

            if (!border.Contains(Display.position))
            {
                ++Display.position;
                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        //Controls for values
        public static void One(int index, System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var num = new Image();
            num.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\1.png"));
            var brush = new ImageBrush(num.Source);

            if (!Protection.protectedIndex.Contains(index))
            {
                Values.EnteredValues.RemoveAt(index);
                Values.EnteredValues.Insert(index, brush);

                Values.lvlValues[index / 9].RemoveAt(index % 9);
                Values.lvlValues[index / 9].Insert(index % 9, 1);

                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        public static void Two(int index, System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var num = new Image();
            num.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\2.png"));
            var brush = new ImageBrush(num.Source);

            if (!Protection.protectedIndex.Contains(index))
            {
                Values.EnteredValues.RemoveAt(index);
                Values.EnteredValues.Insert(index, brush);

                Values.lvlValues[index / 9].RemoveAt(index % 9);
                Values.lvlValues[index / 9].Insert(index % 9, 2);

                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        public static void Three(int index, System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var num = new Image();
            num.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\3.png"));
            var brush = new ImageBrush(num.Source);

            if (!Protection.protectedIndex.Contains(index))
            {
                Values.EnteredValues.RemoveAt(index);
                Values.EnteredValues.Insert(index, brush);

                Values.lvlValues[index / 9].RemoveAt(index % 9);
                Values.lvlValues[index / 9].Insert(index % 9, 3);

                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        public static void Four(int index, System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var num = new Image();
            num.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\4.png"));
            var brush = new ImageBrush(num.Source);

            if (!Protection.protectedIndex.Contains(index))
            {
                Values.EnteredValues.RemoveAt(index);
                Values.EnteredValues.Insert(index, brush);

                Values.lvlValues[index / 9].RemoveAt(index % 9);
                Values.lvlValues[index / 9].Insert(index % 9, 4);

                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        public static void Five(int index, System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var num = new Image();
            num.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\5.png"));
            var brush = new ImageBrush(num.Source);

            if (!Protection.protectedIndex.Contains(index))
            {
                Values.EnteredValues.RemoveAt(index);
                Values.EnteredValues.Insert(index, brush);

                Values.lvlValues[index / 9].RemoveAt(index % 9);
                Values.lvlValues[index / 9].Insert(index % 9, 5);

                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        public static void Six(int index, System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var num = new Image();
            num.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\6.png"));
            var brush = new ImageBrush(num.Source);

            if (!Protection.protectedIndex.Contains(index))
            {
                Values.EnteredValues.RemoveAt(index);
                Values.EnteredValues.Insert(index, brush);

                Values.lvlValues[index / 9].RemoveAt(index % 9);
                Values.lvlValues[index / 9].Insert(index % 9, 6);

                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        public static void Seven(int index, System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var num = new Image();
            num.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\7.png"));
            var brush = new ImageBrush(num.Source);

            if (!Protection.protectedIndex.Contains(index))
            {
                Values.EnteredValues.RemoveAt(index);
                Values.EnteredValues.Insert(index, brush);

                Values.lvlValues[index / 9].RemoveAt(index % 9);
                Values.lvlValues[index / 9].Insert(index % 9, 7);

                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        public static void Eight(int index, System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var num = new Image();
            num.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\8.png"));
            var brush = new ImageBrush(num.Source);

            if (!Protection.protectedIndex.Contains(index))
            {
                Values.EnteredValues.RemoveAt(index);
                Values.EnteredValues.Insert(index, brush);

                Values.lvlValues[index / 9].RemoveAt(index % 9);
                Values.lvlValues[index / 9].Insert(index % 9, 8);

                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

        public static void Nine(int index, System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var num = new Image();
            num.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\9.png"));
            var brush = new ImageBrush(num.Source);

            if (!Protection.protectedIndex.Contains(index))
            {
                Values.EnteredValues.RemoveAt(index);
                Values.EnteredValues.Insert(index, brush);

                Values.lvlValues[index / 9].RemoveAt(index % 9);
                Values.lvlValues[index / 9].Insert(index % 9, 9);

                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }

        }

        public static void Delete(int index, System.Windows.Controls.Primitives.UniformGrid board, System.Windows.Window main)
        {
            var num = new Image();
            num.Source = new BitmapImage(new Uri(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\0.png"));
            var brush = new ImageBrush(num.Source);

            if (!Protection.protectedIndex.Contains(index))
            {
                Values.EnteredValues.RemoveAt(index);
                Values.EnteredValues.Insert(index, brush);

                Values.lvlValues[index / 9].RemoveAt(index % 9);
                Values.lvlValues[index / 9].Insert(index % 9, 0);

                Display.DrawBoard(board, main);
            }
            else
            {
                Display.DrawBoard(board, main);
            }
        }

    }
}
