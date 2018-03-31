using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\level1.txt";
            int txtValues = int.Parse(File.ReadAllLines(path)[0][0].ToString());
            var lvlValues = new List<List<int>>();
            for (int i = 0; i < 9; i++)
            {
                lvlValues.Add(new List<int>());
                for (int j = 0; j < 9; j++)
                {
                    lvlValues[i].Insert(j, int.Parse(File.ReadAllLines(path)[i][j].ToString()));
                }
            }

            foreach (var item in lvlValues[1])
            {
            Console.WriteLine(item);

            }
            Console.Read();
            //    var lvlValues = new List<List<int>>();
            //    lvlValues.Add(new List<int> { 8, 2, 4, 9, 5, 3, 6, 7, 1 });
            //    lvlValues.Add(new List<int> { 6, 3, 5, 8, 1, 7, 9, 2, 4 });
            //    lvlValues.Add(new List<int> { 7, 1, 9, 6, 2, 4, 8, 5, 3 });
            //    lvlValues.Add(new List<int> { 5, 8, 7, 2, 9, 1, 3, 4, 6 });
            //    lvlValues.Add(new List<int> { 1, 4, 2, 7, 3, 6, 5, 8, 9 });
            //    lvlValues.Add(new List<int> { 3, 9, 6, 4, 8, 5, 2, 1, 7 });
            //    lvlValues.Add(new List<int> { 2, 6, 1, 5, 4, 9, 7, 3, 8 });
            //    lvlValues.Add(new List<int> { 4, 7, 8, 3, 6, 2, 1, 9, 5 });
            //    lvlValues.Add(new List<int> { 9, 5, 3, 1, 7, 8, 4, 6, 2 });

            //    //check for columns
            //    int columnCheck = 0;
            //    var tempColumn = new List<int>();
            //    for (int i = 0; i < lvlValues.Count; i++)
            //    {
            //        for (int j = 0; j < lvlValues.Count; j++)
            //        {
            //            tempColumn.Add(lvlValues[j][i]);
            //        }
            //        if (tempColumn.Distinct().Count() == 9)
            //        {
            //            columnCheck++;
            //        }
            //    }

            //    //check for rows
            //    int rowCheck = 0;
            //    var tempRow = new List<int>();
            //    for (int i = 0; i < lvlValues.Count; i++)
            //    {
            //        for (int j = 0; j < lvlValues.Count; j++)
            //        {
            //            tempRow.Add(lvlValues[i][j]);
            //        }
            //        if (tempRow.Distinct().Count() == 9)
            //        {
            //            rowCheck++;
            //        }
            //    }

            //    //check for tables
            //    int tableCheck = 0;
            //    var tempTable = new List<int>();
            //    for (int columnIndex = 0; columnIndex < 9; columnIndex+=3)
            //    {
            //        for (int rowIndex = 0; rowIndex < 9; rowIndex+=3)
            //        {
            //            for (int i = columnIndex; i < 3+columnIndex; i++)
            //            {
            //                for (int j = rowIndex; j < 3+rowIndex; j++)
            //                {
            //                    tempTable.Add(lvlValues[i][j]);
            //                }
            //            }
            //            if (tempTable.Distinct().Count() == 9)
            //            {
            //                tableCheck++;
            //            }
            //        }
            //    }

            //    int totalCheck = rowCheck + columnCheck + tableCheck;
            //    if (totalCheck == 27)
            //    {
            //        Console.WriteLine("gooooood");
            //    }
            //    else
            //    {
            //        Console.WriteLine("no");
            //    }

            //    int rowindex = 51 / 10;
            //    int index = 51 % 10;
            //    Console.WriteLine(rowindex);
            //    Console.WriteLine(index);
            //    Console.Read();

        }
    }
}
