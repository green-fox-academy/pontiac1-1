using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exercise1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exercise1.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static int id = 0;
        [Route("greeting")]
        public IActionResult Greeting(string name = null)
        {
            var greeting = new Greeting()
            {
                Content = $"Hello {name}, this site was loaded {++id} times since last server start"
            };
            return View(greeting);
        }
    }
}
