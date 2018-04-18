using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Services;
using Reddit.DTOs;
using Reddit.Entities;

namespace Reddit.Controllers
{
    [Route("")]
    public class AuthController : Controller
    {
        IAuth auth;

        public AuthController(IAuth auth)
        {
            this.auth = auth;
        }

        [Route("Login/")]
        [HttpGet]
        public IActionResult Login(string name)
        {
            return Json(new LogDTO { Message = auth.Login(name) });
        }
    }
}