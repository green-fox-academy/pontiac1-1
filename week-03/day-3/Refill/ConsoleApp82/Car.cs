using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    public class Car
    {
        public double Capacity;
        public double Tank;

        public Car(double Capacity = 100, double Tank = 0)
        {
            this.Capacity = Capacity;
            this.Tank =Tank;
        }
    }
}
