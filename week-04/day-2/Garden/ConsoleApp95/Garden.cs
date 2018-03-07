using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp95
{
    class Garden
    {
        public List<Tree> trees;
        public List<Flower> flowers;

        public Garden(List<Tree> trees, List<Flower> flowers)
        {
            this.trees = trees;
            this.flowers = flowers;
        }

        public void PlantTree(Tree a)
        {
            trees.Add(a);
        }

        public void PlantFlowers(Flower a)
        {
            flowers.Add(a);
        }


        public virtual void Water(double a)
        {
            int towater = 0;
            foreach (var flower in flowers)
            {
                if (flower.waterAmt < 5)
                {
                    towater++;
                }
            }

            foreach (var tree in trees)
            {
                if (tree.waterAmt < 10)
                {
                    towater++;
                }
            }

            foreach (var flower in flowers)
            {
                if (flower.waterAmt < 5)
                {
                    flower.waterAmt += (a / towater) * 0.75;
                }
            }
            foreach (var tree in trees)
            {
                if (tree.waterAmt < 10)
                {
                    tree.waterAmt += (a / towater) * 0.4;
                }
            }
        }

        public void Status()
        {
            foreach (var tree in trees)
            {
                Console.WriteLine(tree.color + " Tree, Water Amount: " + tree.waterAmt + ", " + tree.Status());
            }
            foreach (var flower in flowers)
            {
                Console.WriteLine(flower.color + " Flower, Water Amount: "+flower.waterAmt + ", " +flower.Status());
            }
        }
    }
}
