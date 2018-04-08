using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MManager.Serives;
using MManager.Services;

namespace MManager.Controllers
{
    [Route("Profile")]
    public class ProfileController : Controller
    {
        IManage manager;
        IAuth authenticator;

        public ProfileController(IManage manager, IAuth authenticator)
        {
            this.manager = manager;
            this.authenticator = authenticator;
        }

        [Route("Index")]
        public IActionResult Index()
        {          
            return View();
        }

        [Route("openaccount")]
        public IActionResult OpenAccount()
        {
            return View();
        }

        [Route("logout")]
        public IActionResult LogOut()
        {
            authenticator.LogOut();
            return Redirect("../Auth/SignIn");
        }
    }
}