using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDO_AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalShelter = new AnimalShelter();

            animalShelter.Rescue(new Cat());
            animalShelter.Rescue(new Dog("Furkesz"));
            animalShelter.Rescue(new Parrot());
            Console.WriteLine(animalShelter.ToString());

            Console.WriteLine();

            animalShelter.Heal();
            Console.WriteLine(animalShelter.ToString());

            Console.WriteLine();

            animalShelter.AddAdopter("Kond");
            Console.WriteLine(animalShelter.ToString());

            Console.WriteLine();

            animalShelter.FindNewOwner();
            animalShelter.EarnDonation(30);
            Console.WriteLine(animalShelter.ToString());

            Console.Read();
        }
    }
}
