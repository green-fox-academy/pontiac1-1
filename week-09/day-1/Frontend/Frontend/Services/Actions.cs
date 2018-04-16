using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Services
{
    public class Actions : IActions
    {
        public string AppendA(string wordToAppendTo)
        {
            return wordToAppendTo + 'a';
        }

        public int? Double(int? intToDouble)
        {
            return intToDouble * 2;
        }

        public int Factor(int intToFactor)
        {
            if (intToFactor == 1)
            {
                return 1;
            }
            else
            {
                return intToFactor * Factor(--intToFactor);
            }
        }

        public string Greet(string Name)
        {
            return $"Hello {Name}";
        }

        public int Sum(int intToSumUntil)
        {
            if (intToSumUntil == 1)
            {
                return 1;
            }
            else
            {
                return intToSumUntil + Sum(--intToSumUntil);
            }
        }

        public string ThrowError()
        {
            return "No input";
        }
    }
}
