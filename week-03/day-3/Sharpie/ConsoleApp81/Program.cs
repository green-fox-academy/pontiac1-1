using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    class Program
    {
        static void Main(string[] args)
        {
            var toll = new Sharpie("Blue", 0.1, 100);
            string mystring = "o legyen ar vege bazdmeg!";
            for (int i = 0;  i < mystring.Length;  i++)
            {
                toll.use();
            }
            Console.WriteLine(toll.InkAmt);
            Console.Read();
        }
    }
}
