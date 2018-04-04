using Microsoft.AspNetCore.Mvc;
using REDO.Models;

namespace REDO.Controllers
{
    public class BankController : Controller
    {
        [Route("Accounts")]
        [HttpGet]
        public IActionResult Accounts()
        {
            return View(BankAccounts.Accounts);
        }

        [HttpPost]
        [Route("Accounts")]
        public IActionResult Accounts(int index)
        {
            BankAccounts.Accounts[index].Increase();
            return View(BankAccounts.Accounts);
        }

        [Route("Add")]
        [HttpPost]
        public IActionResult Accounts(string name, double balance, string type, bool isking)
        {
            BankAccounts.Accounts.Add(new BankAccount() { Name = name, Balance = balance, Type = type, IsKing = isking });
            return View(BankAccounts.Accounts);
        }
    }
}