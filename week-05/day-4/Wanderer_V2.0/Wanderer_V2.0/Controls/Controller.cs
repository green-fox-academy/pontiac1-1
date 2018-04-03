using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wanderer_V2._0.View;
using System.Collections.Generic;
using System.IO;

namespace Wanderer_V2._0.Controls
{
    class Controller
    {
        public static bool midair;
        public static int position = 200;
        public static int startindex = 0;
        public static int endindex = 20;


        public static void D(System.Windows.Controls.Primitives.UniformGrid screen)
        {
            var walls = new List<int>();
            for (int i = 19; i < 240; i+=20)
            {
                walls.Add(i);
            }

            if (!walls.Contains(position))
            {
                Display.Player1(screen, ++position, "heroright");
                Display.Monster(screen);
            }
            else
            {
                Display.Player1(screen, position, "heroright");
                Display.Monster(screen);
            }
        }

        public static void A(System.Windows.Controls.Primitives.UniformGrid screen)
        {
            var walls = new List<int>();
            for (int i = 0; i < 220; i+=20)
            {
                walls.Add(i);
            }

            if (!walls.Contains(position))
            {
            Display.Player1(screen, --position, "heroleft");
                Display.Monster(screen);
            }
            else
            {
            Display.Player1(screen, position, "heroleft");
                Display.Monster(screen);
            }
        }

        public static async void MoveMonster(int millisec, System.Windows.Controls.Primitives.UniformGrid screen, int position = 219)
        {
            var rnd = new Random();
            await Task.Delay(millisec);
            Display.Monster(screen, position += rnd.Next(-1, 1), "heroright");
        }

    }
}
