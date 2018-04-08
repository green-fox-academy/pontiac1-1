using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheFoxClub.Controllers
{
    [Route("/")]
    public class FoxController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}