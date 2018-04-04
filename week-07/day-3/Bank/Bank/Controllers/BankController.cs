using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bank.Models;

namespace Bank.Controllers
{
    
    public class BankController : Controller
    {
        
        [Route("Simba")]
        public IActionResult BankAccount()
        {
            var simba = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Lion"
            };
            return View(simba);
        }
    }
}
