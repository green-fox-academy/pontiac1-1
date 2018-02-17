using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int cHour = 14;
            int cMinute = 34;
            int cSecond = 42;

            int totalsecs = 24 * 60 * 60;
            int tosub = (cHour * 60 * 60) + (cMinute * 60) + cSecond;

            int rem = totalsecs - tosub;
            Console.WriteLine(rem);
            Console.ReadLine();
        }
    }
}
