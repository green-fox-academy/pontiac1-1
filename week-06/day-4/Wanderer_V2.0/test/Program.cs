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
            int lvl = 1;
            string lvlPath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-4\Wanderer_V2.0\Wanderer_V2.0\Assets\levels\level_1.txt";
            string[] level = File.ReadAllLines(lvlPath);

            foreach (var item in level)
            {
                foreach (var kaki in item)
                {
                    Console.WriteLine(kaki);
                }
            }
            Console.Read();
        }
    }
}
