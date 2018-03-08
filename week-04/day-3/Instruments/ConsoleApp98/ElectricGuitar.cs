using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp98
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int numofStrings)
        {

        }

        public override string Sound()
        {
            return "twangs";
        }

        public override string Play()
        {
            return "Electric Guitar, a " + numOfStrings + "-stringed instument that " + Sound();
        }

    }
}
