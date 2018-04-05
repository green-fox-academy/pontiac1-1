using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagram.Services
{
    public class AnagramInjection : IAnagram
    { 
        public string IfAnagram(string first, string second)
        {
            if (first == null || second == null)
            {
                return "Incorrect input";
            }
            else if (String.Concat(first.OrderBy(x => x)).ToLower().Equals
                (String.Concat(second.OrderBy(x => x)).ToLower()) && first != second)
            {
                return "All good";
            }
            else
            {
                return "Nah, bro, aint no anagrams around";
            }
        }
    }
}
