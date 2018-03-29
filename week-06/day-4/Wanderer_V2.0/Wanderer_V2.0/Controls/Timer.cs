using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer_V2._0.Controls
{
    class Timer
    {
        public static async void Delay(int millisec)
        {
            await Task.Delay(millisec);
        }
    }
}
