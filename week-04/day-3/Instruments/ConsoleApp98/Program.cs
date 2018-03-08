using System;

namespace ConsoleApp98
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVio = new Violin(4);
            var myTelecaster = new ElectricGuitar(6);
            var myGibson = new Bass(4);
            Console.WriteLine(myVio.Play());
            Console.WriteLine(myTelecaster.Play());
            Console.WriteLine(myGibson.Play());
            Console.Read();
        }
    }
}
