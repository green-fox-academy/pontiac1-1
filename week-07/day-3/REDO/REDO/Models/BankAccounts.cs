using System.Collections.Generic;

namespace REDO.Models
{
    public class BankAccounts
    {
        public static List<BankAccount> Accounts = new List<BankAccount>
        {
            new BankAccount(){Name="Blanka", Balance=2000.00, Type="Lion"},
            new BankAccount(){Name="Mark", Balance=2000.00, Type="Tiger"},
            new BankAccount(){Name="Arno", Balance=2000.00, Type="Monkey"},
            new BankAccount(){Name="Dani", Balance=2000.00, Type="Snake"},
            new BankAccount(){Name="Miki", Balance=2000.00, Type="Lion"},
        };
    }
}
