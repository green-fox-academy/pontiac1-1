using Microsoft.AspNetCore.Mvc;
using REDO.Models;

namespace REDO.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static int count = 0;
        [Route("greeting")]
        public IActionResult Greeting(string name = "World")
        {
            var greeting = new Greeting()

            {
                Name = name,
                VisitCount = ++count
            };

            return View(greeting);
        }
    }
}
