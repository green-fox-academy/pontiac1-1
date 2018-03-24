using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDO_AnimalShelter
{
    class Animal
    {
        private string name;
        private bool healthy;
        protected int healCost;

        public bool Healthy { get => healthy; }
        public int HealCost { get => healCost; }

        public Animal(string name, int healCost)
        {
            this.name = name;
            this.healCost = healCost;
            this.healthy = false;
        }

        public void Heal()
        {
            this.healthy = true;
        }

        public bool isAdoptable()
        {
            return this.healthy;
        }

        public string ToString()
        {
            if (this.healthy)
                return $"{this.name} is healthy and adoptable\n";            
            else
                return $"{this.name} is not healthy (${this.healCost}€), and not adoptable\n";

        }
    }
}
