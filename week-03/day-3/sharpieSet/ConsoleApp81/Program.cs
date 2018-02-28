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
            SharpieSet mySharpies = new SharpieSet();
            Sharpie first = new Sharpie("red", 0.1, 100);
            Sharpie second = new Sharpie("blue", 0.2, 0);
            mySharpies.Sharpielist.Add(first);
            mySharpies.Sharpielist.Add(second);
            
            Console.WriteLine(mySharpies.CountUsable());
            Console.WriteLine(mySharpies.Sharpielist[1].InkAmt);
            mySharpies.RemoveEmpty();
            foreach (var item in mySharpies.Sharpielist)
            {
                Console.WriteLine(item.InkAmt);

            }

            Console.Read();
        }
    }
}
