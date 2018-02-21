using System;
using System.Collections.Generic;

namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {

            var map = new List<Dictionary<string, object>>();


            var row0 = new Dictionary<string, object>();
             row0.Add("name", "Rezso");
             row0.Add("age", 9.5);
             row0.Add("candies", 2);
             map.Add(row0);

            var row1 = new Dictionary<string, object>();
             row1.Add("name", "Gerzson");
             row1.Add("age", 10);
             row1.Add("candies", 1);
             map.Add(row1);

            var row2 = new Dictionary<string, object>();
             row2.Add("name", "Aurel");
             row2.Add("age", 7);
             row2.Add("candies", 3);
             map.Add(row2);

            var row3 = new Dictionary<string, object>();
             row3.Add("name", "Zsombor");
             row3.Add("age", 12);
             row3.Add("candies", 5);
             map.Add(row3);

            var row4 = new Dictionary<string, object>();
             row4.Add("name", "Olaf");
             row4.Add("age", 12);
             row4.Add("candies", 7);
             map.Add(row4);

            var row5 = new Dictionary<string, object>();
             row5.Add("name", "Teodor");
             row5.Add("age", 3);
             row5.Add("candies", 2);
             map.Add(row5);

            
            foreach (var row in map)
            {
                int x = int.Parse(row["candies"].ToString());
                
                if (x > 4)
                {
                    Console.WriteLine(row["name"]);
                }
                if (x < 5)
                {

                }
            }

            double sum = 0;
            for (int i = 0; i < map.Count; i++)
            {
                
                if (int.Parse(map[i]["candies"].ToString()) < 5)
                {
                    sum += double.Parse(map[i]["age"].ToString());
                }
            }
            Console.WriteLine(sum);

            


            Console.ReadLine();
            
        }
    }
}
