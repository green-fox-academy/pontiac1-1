using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Type { get; set; }
        public bool IsKing { get; set; }

        public void Increase()
        {
            Balance += IsKing ? 100 : 10;
        }
    }
}
