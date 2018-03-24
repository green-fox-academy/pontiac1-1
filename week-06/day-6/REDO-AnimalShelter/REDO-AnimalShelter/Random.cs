using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDO_AnimalShelter
{
    static class Random
    {
        private static System.Random random = new System.Random();

        public static int RandomInt(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}
