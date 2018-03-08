using System;
using System.Collections.Generic;
using System.Text;

namespace Sum
{
    public class Summer
    {
        protected static int sum = 0;

        public Summer()
        {

        }

        public static int GetValue(List<int> numlist)
        {
            sum = 0;
            foreach (var num in numlist)
            {
                sum += num;
            }

            return sum;
        }
    }
}
