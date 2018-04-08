using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MManager.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}