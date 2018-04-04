using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Models
{
    public class BankAccounts
    {
        public static List<BankAccount> Accounts;
        public BankAccounts()
        {
            Accounts = new List<BankAccount>();
            Accounts.Add(new BankAccount() { Name = "Simba", Balance = 2000.00, Type = "Lion", IsKing = true});
            Accounts.Add(new BankAccount() { Name = "Zordon", Balance = 1000.00, Type = "Lion" });
            Accounts.Add(new BankAccount() { Name = "Nala", Balance = 0.00, Type = "Lion" });
            Accounts.Add(new BankAccount() { Name = "Rafiki", Balance = 200.00, Type = "Monkey" });
        }
    }
}
