using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagram.Services
{
    public interface IAnagram
    {
        string IfAnagram(string first, string second);
    }
}
