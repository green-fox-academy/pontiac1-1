using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Documents;

namespace WpfApp2
{
    static class Controls
    {
        static int position;     
        public static void W(System.Windows.Controls.Primitives.UniformGrid map)
        {


            string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\level1.txt";
            string wallOrFloor = File.ReadAllText(path);
            var walls = new List<int>();
            int index = position;
            for (int i = 0; i < wallOrFloor.Length; i++)
            {
                if (wallOrFloor[i] == '1')
                {
                    walls.Add(i);
                }
            }

            try
            {
                if (!walls.Contains(index -= 10))
                {
                    position -= 10;
                    Draw.DrawHero(map, "heroback", position);
                }
                else
                {
                    Draw.DrawHero(map, "heroback", position);
                    
                }
            }
            catch (IndexOutOfRangeException)
            {
                position += 10;
                Draw.DrawHero(map, "heroback", position);               
            }
        }

        public static void A(System.Windows.Controls.Primitives.UniformGrid map)
        {
            string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\level1.txt";
            string wallOrFloor = File.ReadAllText(path);
            var walls = new List<int>();
            int index = position;
            for (int i = 0; i < wallOrFloor.Length; i++)
            {
                if (wallOrFloor[i] == '1')
                {
                    walls.Add(i);
                }
            }

            if (position % 10 != 0)
            {
                if (!walls.Contains(--index))
                {
                    Draw.DrawHero(map, "heroleft", --position);
                }
                else
                {
                    Draw.DrawHero(map, "heroleft", position);
                }
            }
            else
            {
                Draw.DrawHero(map, "heroleft", position);
            }
        }

        public static void S(System.Windows.Controls.Primitives.UniformGrid map)
        {
            string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\level1.txt";
            string wallOrFloor = File.ReadAllText(path);
            var walls = new List<int>();
            int index = position;
            for (int i = 0; i < wallOrFloor.Length; i++)
            {
                if (wallOrFloor[i] == '1')
                {
                    walls.Add(i);
                }
            }

            try
            {
                if (!walls.Contains(index += 10))
                {
                    position += 10;
                    Draw.DrawHero(map, "herofront", position);
                }
                else
                {
                    Draw.DrawHero(map, "herofront", position);
                }
            }
            catch (IndexOutOfRangeException)
            {
                position -= 10;
                Draw.DrawHero(map, "herofront", position);
            }
        }

        public static void D(System.Windows.Controls.Primitives.UniformGrid map)
        {
            string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\level1.txt";
            string wallOrFloor = File.ReadAllText(path);
            var walls = new List<int>();
            int index = position;
            for (int i = 0; i < wallOrFloor.Length; i++)
            {
                if (wallOrFloor[i] == '1')
                {
                    walls.Add(i);
                }
            }

            if (position % 10 != 9)
            {
                if (!walls.Contains(++index))
                {
                    Draw.DrawHero(map, "heroright", ++position);
                }
                else
                {
                    Draw.DrawHero(map, "heroright", position);
                }
            }
            else
            {
                Draw.DrawHero(map, "heroright", position);
            }
        }
    }
}
