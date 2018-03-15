using System;

namespace GameBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var Miki = new Monster(1);
            var Mikker = new Boss();
            Console.WriteLine(Miki.HP);
            Console.WriteLine(Mikker.HP);
            Console.Read();
        }
    }
}
