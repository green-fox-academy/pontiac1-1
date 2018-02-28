using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    class Station
    {
        public double GasAmt;

        public Station(double GasAmt = 1000)
        {
            this.GasAmt = GasAmt;
        }
        public void Refill(Car c)
        {
            GasAmt -= c.Capacity - c.Tank;
            c.Tank+= c.Capacity - c.Tank;
        }
    }
}
