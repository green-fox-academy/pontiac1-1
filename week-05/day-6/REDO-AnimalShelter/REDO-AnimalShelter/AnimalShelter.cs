using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDO_AnimalShelter
{
    class AnimalShelter
    {
        private int budget;
        private List<Animal> animals;
        private List<string> adopters;

        public AnimalShelter()
        {
            this.budget = 50;
            this.animals = new List<Animal>();
            this.adopters = new List<string>();
        }

        public int Rescue(Animal toRescue)
        {
            animals.Add(toRescue);
            return animals.Count;
        }

        public int Heal()
        {
            var unhealthy = this.animals.Find(animal => !animal.Healthy);
            if (unhealthy != null && unhealthy.HealCost <= this.budget)
            {
                unhealthy.Heal();
                this.budget -= unhealthy.HealCost;
                return 1;
            }
            return 0;
        }

        public void AddAdopter(string adopter)
        {
            adopters.Add(adopter);
        }

        public void FindNewOwner()
        {
            if (this.adopters.Count == 0 || this.animals.Count == 0)
            {
                throw new Exception("no adopters or animals");
            }

            var newOwner = this.adopters[Random.RandomInt(0, adopters.Count - 1)];
            var luckyAnimal = this.animals[Random.RandomInt(0, animals.Count - 1)];

            if (luckyAnimal.isAdoptable())
            {
                animals.Remove(luckyAnimal);
                adopters.Remove(newOwner);
            }
        }

        public int EarnDonation(int amt)
        {
            this.budget += amt;
            return this.budget;
        }

        public string ToString()
        {
            string shelterStat = $"Budget: {budget}€, There are {animals.Count} animal(s) and ${adopters.Count} potential adopter(s)\n";
            var animalsStat = new StringBuilder();

            foreach (var animal in animals)
            {
                animalsStat.Append(animal.ToString());
            }

            return shelterStat + animalsStat;
        }
    }
}
