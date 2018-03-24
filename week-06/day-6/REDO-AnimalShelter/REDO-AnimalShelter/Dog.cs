using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDO_AnimalShelter
{
    class Dog : Animal
    {
        public Dog(string name = "Dog") : base(name, Random.RandomInt(0, 8)) { }
    }
}
