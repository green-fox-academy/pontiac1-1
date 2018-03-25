using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace REDO_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-6\REDO-Words\REDO-Words\content.txt";
            Console.WriteLine(MakeItFamilyFriendly(path));
            Console.Read();
        }

        static int MakeItFamilyFriendly(string path)
        {
            var offensiveWords = new List<string>() { "fuck", "bloody", "cock", "shit", "fucker", "fuckstick", "asshole", "dick", "piss" };
            string[] content = File.ReadAllText(path).ToLower().Split(' ', '.', ',');
            var familyFriendlyContent = new StringBuilder();

            int match = 0;

            foreach (var word in content)
            {
                if (offensiveWords.Contains(word))
                {
                    match++;
                }
                else
                    familyFriendlyContent.Append(word);
            }

            File.WriteAllText(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-6\REDO-Words\REDO-Words\FFcontent.txt", familyFriendlyContent.ToString());
            return match;
        }
    }
}
