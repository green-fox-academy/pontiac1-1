using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\level1.txt";
            //string wallOrFloor = File.ReadAllText(path);
            //var walls = new List<int>();
            //for (int i = 0; i < wallOrFloor.Length; i++)
            //{
            //    if (wallOrFloor[i] == '1')
            //    {
            //        walls.Add(i);
            //    }
            //}


            int a = 33;
            int up = a - 10;
            int down = a + 10;
            int left = a - 1;
            int right = a + 1;
            var moves = new List<int>();
            moves.Add(up);
            moves.Add(down);
            moves.Add(left);
            moves.Add(right);

            foreach (var item in moves)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
