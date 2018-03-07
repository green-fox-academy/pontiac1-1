using System;
using System.Collections.Generic;

namespace ConsoleApp95
{
    class Program
    {
        static void Main(string[] args)
        {
            var trees = new List<Tree>();
            var flowers = new List<Flower>();

            var myGarden = new Garden(trees, flowers);

            var firstTree = new Tree("yellow", 5);
            var secondTree = new Tree("orange", 12);
            var firstFlower = new Flower("Red", 2);
            var secondFlower = new Flower("Black", 16);

            myGarden.PlantFlowers(firstFlower);
            myGarden.PlantFlowers(secondFlower);
            myGarden.PlantTree(firstTree);
            myGarden.PlantTree(secondTree);

            myGarden.Status();
            myGarden.Water(100);
            myGarden.Status();
            Console.Read();
        }
    }
}
