using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Model
{
    class Protection
    {
        public static List<int> protectedIndex;
        public static void Protect()
        {
            protectedIndex = new List<int>();
            for (int i = 0; i < Values.lvlValues.Count; i++)
            {
                for (int j = 0; j < Values.lvlValues[i].Count; j++)
                {
                    if (Values.lvlValues[i][j] != 0)
                    {
                        protectedIndex.Add(i*9+j);
                    }
                }
            }
        }
    }
}
