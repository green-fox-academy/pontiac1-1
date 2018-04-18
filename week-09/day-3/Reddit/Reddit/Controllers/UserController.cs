using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Services;
using Reddit.Models;
using Reddit.DTOs;

namespace Reddit.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        ICrud<User> uc;

        public UserController(ICrud<User> uc)
        {
            this.uc = uc;
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create(UserDTO newUser)
        {
            return Json(uc.Create(new User { Name = newUser.Name }));
        }

        [Route("read")]
        [HttpGet]
        public IActionResult Read()
        {
            return Json(uc.Read());
        }

        [Route("update")]
        [HttpPost]
        public IActionResult Update()
        {
            return View();
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult Delete(string name)
        {
            return Json(uc.Delete(name));
        }
    }
}