using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDO_AnimalShelter
{
    class Animal
    {
        public string name;
        public bool healthy;
        public int healCost;
        
        public Animal()
        {

        }

        public void Heal()
        {
            healthy = true;
        }

        public bool isAdoptable()
        {
            if (healthy == true)
                return true;
            else
            return false;
        }

        public string toString()
        {
            return name + " is not healty (" + healCost + "$), cannot be adopted.";
        }
    }
}
