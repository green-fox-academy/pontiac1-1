using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Account.Models;

namespace Account.Controllers
{
    public class BankController : Controller
    {
        static BankAccounts bankAccounts = new BankAccounts();

        [Route("Simba")]
        [HttpGet]
        public IActionResult Simba()
        {
            return View(bankAccounts);
        }

        [Route("Simba")]
        [HttpPost]
        public IActionResult Simba(int index)
        {
            BankAccounts.Accounts[index].Increase();
            return View(bankAccounts);
        }

        [Route("Add")]
        [HttpPost]
        public IActionResult Simba(string name, double balance, string type, bool isking)
        {
            BankAccounts.Accounts.Add(new BankAccount() { Name = name, Balance = balance, Type = type, IsKing = isking});
            return View(bankAccounts);
        }
    }
}