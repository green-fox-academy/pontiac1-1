using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mk1 = new Car(100, 40);
            Station shell = new Station();
            shell.Refill(mk1);

            Console.WriteLine(shell.GasAmt);
            Console.Read();
        }
    }
}
