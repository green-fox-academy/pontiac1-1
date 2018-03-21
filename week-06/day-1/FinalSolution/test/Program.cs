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



            string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\level1.txt";
            string wallOrFloor = File.ReadAllText(path);
            var floors = new List<int>();

            for (int i = 0; i < wallOrFloor.Length; i++)
            {
                if (wallOrFloor[i] == '0')
                {
                    floors.Add(i);
                }
            }

            Console.WriteLine(floors[0]);
            Console.WriteLine(floors.Last());
            Console.WriteLine();
            foreach (var item in floors)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
