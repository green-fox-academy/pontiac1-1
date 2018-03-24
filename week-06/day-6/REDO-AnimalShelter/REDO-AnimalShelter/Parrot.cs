using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDO_AnimalShelter
{
    class Parrot : Animal
    {
        public Parrot(string name = "Parrot") : base(name, Random.RandomInt(4, 10)) { }
    }
}
