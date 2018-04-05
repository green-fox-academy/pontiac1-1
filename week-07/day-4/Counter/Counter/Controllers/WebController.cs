using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Counter.Services;

namespace Counter.Controllers
{
    [Route("/")]
    public class WebController : Controller
    {
        private ICounter count;

        public WebController(ICounter counter)
        {
            this.count = counter;
        }

        [HttpGet]
        [Route("Counter")]
        public IActionResult Counter()
        {
            return View(count.GetCount());
        }

        [HttpPost]
        [Route("Increase")]
        public IActionResult Increase()
        {
            count.Count();
            return RedirectToAction("Counter");
        }
    }
}