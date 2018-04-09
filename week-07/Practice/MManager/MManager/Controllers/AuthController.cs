using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MManager.Services;
using MManager.Models;

namespace MManager.Controllers
{
    [Route("Auth")]
    public class AuthController : Controller
    {
        IAuth authenticator;

        public AuthController(IAuth auth)
        {
            this.authenticator = auth;
        }

        [Route("SignIn")]
        public IActionResult SignIn()
        {
            return View();
        }

        [Route("Login")]
        public IActionResult Login(string user, string pass)
        {          
            return Redirect(authenticator.Authenticate(user, pass));
        }

        [Route("SignUp")]
        public IActionResult SignUp()
        {
            return View();
        }

        [Route("Register")]
        public IActionResult Register(string user, string pass, string repass, double balance)
        {
            var rnd = new Random();
            double id = rnd.Next(1000, 10000);
            authenticator.Register(user, pass, repass, balance, id);
            return RedirectToAction(authenticator.Register(user, pass, repass, balance, id));
        }

        [Route("Profile")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}