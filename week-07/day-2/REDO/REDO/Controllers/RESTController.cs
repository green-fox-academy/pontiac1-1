using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REDO.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REDO.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public static int id = 0;
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greetings();
            greeting.Id = ++id;
            greeting.Content = "Hello " + name;
            return new JsonResult(greeting);
        }
    }
}
