using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MManager.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Pass { get; set; }
        public long AccountID { get; set; }

        public string Greet()
        {
            return $"Welcome inside {Name}";
        }
    }
}
