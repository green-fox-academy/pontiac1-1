using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Services
{
    public interface IActions
    {
        int? Double(int? intToDouble);
        string Greet(string Name);
        string ThrowError();
        string AppendA(string wordToAppendTo);
        int Factor(int intToFactor);
        int Sum(int intToSumUntil);
    }
}
