using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDO_AnimalShelter
{
    class Parrot : Animal
    {
        public Parrot(string name) : base(name)
        {
            healCost = rnd.Next(4, 10);
        }
    }
}
