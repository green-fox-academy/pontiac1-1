using System;
using System.Collections.Generic;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string lvlPath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\Sudoku\Sudoku\Assets\level1.txt";
            string[] values = File.ReadAllLines(lvlPath);
            var lvlValues = new List<char>();

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values[i].Length; j++)
                {
                    lvlValues.Add(values[i][j]);
                }
            }

            for (int i = 0; i < lvlValues.Count; i++)
            {
                Console.WriteLine(lvlValues[i] + i);
            }
            

            Console.Read();
        }
    }
}
