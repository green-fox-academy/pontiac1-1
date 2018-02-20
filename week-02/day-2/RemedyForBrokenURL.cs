using System;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            url = url.Replace("ebot", "od");
            url = url.Insert(5, ":");
     
            Console.WriteLine(url);
            Console.ReadLine();
        }
    }
}
