using System.Collections.Generic;

namespace Account.Models
{
    public class BankAccounts
    {
        public static List<BankAccount> Accounts = new List<BankAccount>() {
        (new BankAccount() { Name = "Simba", Balance = 2000.00, Type = "Lion", IsKing = true}),
        (new BankAccount() { Name = "Zordon", Balance = 1000.00, Type = "Lion" }),
        (new BankAccount() { Name = "Nala", Balance = 0.00, Type = "Lion" }),
        (new BankAccount() { Name = "Rafiki", Balance = 200.00, Type = "Monkey" }) };

        //public BankAccounts()
        //{
        //    Accounts = new List<BankAccount>();
        //    Accounts.Add(new BankAccount() { Name = "Simba", Balance = 2000.00, Type = "Lion", IsKing = true });
        //    Accounts.Add(new BankAccount() { Name = "Zordon", Balance = 1000.00, Type = "Lion" });
        //    Accounts.Add(new BankAccount() { Name = "Nala", Balance = 0.00, Type = "Lion" });
        //    Accounts.Add(new BankAccount() { Name = "Rafiki", Balance = 200.00, Type = "Monkey" });
        //}
    }
}
