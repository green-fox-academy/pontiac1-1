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

        public int[] DoubleArr(int[] arrToDouble)
        {
            for (int i = 0; i < arrToDouble.Length; i++)
            {
                arrToDouble[i] *= 2;
            }
            return arrToDouble;
        }

        public int? Factor(int? intToFactor)
        {
            if (intToFactor == 1)
            {
                return 1;
            }
            else
            {
                return intToFactor * Factor(intToFactor - 1);
            }
        }

        public string Greet(string Name)
        {
            return $"Hello {Name}";
        }

        public int MultiplyArr(int[] arrToMultiply)
        {
            int total = 1;
            foreach (var number in arrToMultiply)
            {
                total *= number;
            }
            return total;
        }

        public int? Sum(int? intToSumUntil)
        {
            if (intToSumUntil == 1)
            {
                return 1;
            }
            else
            {
                return intToSumUntil + Sum(intToSumUntil - 1);
            }
        }

        public int SumArr(int[] arrToSum)
        {
            int sum = 0;
            foreach (var item in arrToSum)
            {
                sum += item;
            }
            return sum;
        }

        public string ThrowError()
        {
            return "No input";
        }
    }
}
