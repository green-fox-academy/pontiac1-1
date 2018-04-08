using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MManager.Models
{
    public class Account
    {
        string AccountBalance { get; set; }
        List<Card> CardList;
    }
}
