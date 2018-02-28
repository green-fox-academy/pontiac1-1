using System;
using System.Collections.Generic;

namespace Dice
{
    public class Dice
    {
        //    You have a Dice class which has 6 dice
        //    You can roll all of them with Roll()
        //    Check the current rolled numbers with GetCurrent()
        //    You can reroll with Reroll()
        //    Your task is to get where all dice is a 6
        static Random RandomValue;
        static public int[] Dices = new int[6];

        public int[] Roll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
            return Dices;
        }

        public int[] GetCurrent()
        {
            return Dices;
        }

        public int GetCurrent(int i)
        {
            return Dices[i];
        }

        public void Reroll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
        }

        public void Reroll(int k)
        {
            Dices[k] = new Random().Next(1, 7);
        }

        public static void Main(string[] args)
        {
            RandomValue = new Random();
            List<Dice> myDice = new List<Dice>();
            myDice.Add(new Dice());
            myDice.Add(new Dice());
            myDice.Add(new Dice());
            myDice.Add(new Dice());
            myDice.Add(new Dice());
            myDice.Add(new Dice());
            //myDice[1].GetCurrent();
            //myDice.Roll();
            //myDice.GetCurrent();
            //myDice.GetCurrent(5);
            //myDice.Reroll();
            //myDice.GetCurrent();
            //myDice.Reroll(4);
            //myDice.GetCurrent();

            for (int i = 0; i < myDice.Count; i++)
            {
                
                while (myDice[i].GetCurrent(i) != 6)
                {
                    myDice[i].Roll();
                foreach (var item in Dices)
                {
                Console.Write(item);
                }
                    //Console.Write(myDice[i].GetCurrent(i)+" ");
                }
                Console.WriteLine();
            }

            Console.Read();
            
        }
    }
}
