using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp98
{
    abstract class StringedInstrument : Instrument
    {
        protected int numOfStrings;

        public override string Play()
        {
            return "" + Sound();
        }

        public abstract string Sound();
    }
}
