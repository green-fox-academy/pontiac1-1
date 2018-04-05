using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Services
{
    public class CountWithRecursion : ICounter
    {
        int start = 0;

        public void Count()
        {
            start++;
        }

        public int GetCount()
        {
            return start;
        }
    }
}
