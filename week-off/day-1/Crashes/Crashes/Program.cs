using System;
using System.IO;

namespace Crashes
{
    class Program
    {
        static void Main(string[] args)
        {
            SplitAndRead();
            Console.Read();
        }

        static void SplitAndRead()
        {
            string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-05\day-1\Crashes\Crashes\crash-incidents.csv";
            string[] content = File.ReadAllLines(path);
            int goodConditions = 0;
            int badConditions = 0;
            for (int i = 0; i < content.Length; i++)
            {
                var condition = content[i].Split(';')[5];

                if (condition == "CLOUDY" || condition == "CLEAR")
                    goodConditions++;               
                else
                    badConditions++;
            }
            Console.Write("The amount of crashes in good weather conditions: {0} \nThe amount of crashes in bad weather conditions: {1}", goodConditions, badConditions);
        }
    }
}
