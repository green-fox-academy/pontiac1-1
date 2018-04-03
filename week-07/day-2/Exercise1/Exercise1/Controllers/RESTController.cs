using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exercise1.Models;

namespace Exercise1.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {          
            var greeting = new Greeting("Hello, "+name);
            return new JsonResult(greeting);
        }
    }
}
