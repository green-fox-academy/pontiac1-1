using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheFoxClub.Models
{
    public class Pet
    {
        string Name { get; set; }
        List<Trick> Tricks {get;set;}
        int Thirst { get; set; }
        int Hunger { get; set; }
    }
}
