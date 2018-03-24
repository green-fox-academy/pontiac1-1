using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wanderer_V2._0.Controls
{
    class Controller
    {
        public static void W()
        {
            string path = @"";
            string wall = File.ReadAllText(path);
            var walls = new List<int>();
            for (int i = 0; i < wall.Length; i++)
            {
                if (wall[i] == '1')
                {
                    walls.Add(i);
                }
            }
        }
    }
}
