using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("")]
    public class AuthsController : Controller
    {
        [Route("")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login(string name, string pass)
        {
            return Redirect();
        }
    }
}