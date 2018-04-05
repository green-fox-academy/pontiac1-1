using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Counter.Services;

namespace Counter.Controllers
{
    [Route("/")]
    public class GreetController : Controller
    {
        IGreetings greet;

        public GreetController(IGreetings greetings)
        {
            this.greet = greetings;
        }

        [Route("greetings")]
        [HttpGet]
        public IActionResult Greetings()
        {
            return View();
        }

        [Route("greet")]
        [HttpPost]
        public IActionResult Greet(string name)
        {
            return View(greet.Greet(name));
        }
    }
}