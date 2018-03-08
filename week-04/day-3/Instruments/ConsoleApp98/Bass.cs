using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp98
{
    class Bass : StringedInstrument
    {
        public Bass(int numofStrings)
        {

        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }

        public override string Play()
        {
            return "Bass, a " + numOfStrings + "-stringed instument that " + Sound();
        }
    }
}
