using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApp2
{
    static class Move
    {

        public static void MoveMonster(System.Windows.Controls.Primitives.UniformGrid map, Monster a)
        {
            int up = a.position - 10;
            int down = a.position + 10;
            int left = a.position - 1;
            int right = a.position + 1;
            var moves = new List<int>();
            moves.Add(up);
            moves.Add(down);
            moves.Add(left);
            moves.Add(right);
            var rnd = new Random();
            int randomMove = rnd.Next(0, 3);
            int newposition = moves[randomMove];

            string levelPath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-1\FinalSolution\WpfApp2\Assets\level1.txt";
            string level = File.ReadAllText(levelPath);
            var walkable = new List<int>();
            for (int i = 0; i < level.Length; i++)
            {
                if (level[i] == '0')
                {
                    walkable.Add(i);
                }
            }

            if (walkable.Contains(newposition))
            {
            a.position = newposition;
            Draw.DrawMonster(map, a.position);
            }

        }
    }
}
