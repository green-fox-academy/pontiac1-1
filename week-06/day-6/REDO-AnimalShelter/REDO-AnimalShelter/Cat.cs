using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDO_AnimalShelter
{
    class Cat : Animal
    {
        public Cat(string name = "Cat") : base(name, Random.RandomInt(1, 6)) { }
    }
}
