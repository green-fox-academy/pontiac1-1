using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using groot.Models;

namespace groot.Controllers
{
    public class GuardianController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/groot")]
        public IActionResult Groot(string message)
        {
            if (message != null)
            {
                return Json(new messageDTO{ Input = message, Output = "I am Groot" });
            }
            else
            {
                return Json(new ErrorDTO { Exception = "I am Groot" });
            }
        }
    }
}