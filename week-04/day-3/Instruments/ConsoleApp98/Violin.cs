using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp98
{
    class Violin : StringedInstrument
    {
        public Violin(int numOfStrings)
        {
            this.numOfStrings = numOfStrings;
        }

        public override string Sound()
        {
            return "screeches";
        }

        public override string Play()
        {
            return "Violin, a " + numOfStrings + "-stringed instument that " + Sound();
        }
    }
}
