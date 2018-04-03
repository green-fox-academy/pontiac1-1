using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank
{
    class Aquarium
    {
        protected List<Fish> aquarium;

        public Aquarium()
        {
            aquarium = new List<Fish>();
        }

        public void Add(Fish newfish)
        {
            aquarium.Add(newfish);
        }
        public void FeedAll()
        {
            foreach (var fish in aquarium)
            {
                fish.Feed();
                fish.Status();
            }
        }

        public void Remove()
        {
            for (int i = 0; i < aquarium.Count; i++)
            {
                if (aquarium[i].mass > 10)
                {
                    aquarium.Remove(aquarium[i]);
                    Console.WriteLine(aquarium[i].name + " is removed");
                }              
            }
        }

        public void Status()
        {
            foreach (var fish in aquarium)
            {
                fish.Status();
            }
        }
    }
}
