using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp76
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object>[] trees = new Dictionary<string, object>[]
            {
                new Dictionary<string, object>(),
                new Dictionary<string, object>(),
                new Dictionary<string, object>(),
                new Dictionary<string, object>(),
                new Dictionary<string, object>()
            };

            trees[0].Add("type", "oak");
            trees[0].Add("leaf", "green");
            trees[0].Add("age", 350);
            trees[0].Add("sex", "male");

            trees[1].Add("type", "pine");
            trees[1].Add("leaf", "green");
            trees[1].Add("age", 350);
            trees[1].Add("sex", "male");

            trees[2].Add("type", "");
            trees[2].Add("leaf", "green");
            trees[2].Add("age", 350);
            trees[2].Add("sex", "male");

            trees[3].Add("type", "oak");
            trees[3].Add("leaf", "green");
            trees[3].Add("age", 350);
            trees[3].Add("sex", "male");

            trees[4].Add("type", "oak");
            trees[4].Add("leaf", "green");
            trees[4].Add("age", 350);
            trees[4].Add("sex", "male");
            Console.WriteLine(trees[0]["type"]);
            Console.Read();

        }

    }
}
