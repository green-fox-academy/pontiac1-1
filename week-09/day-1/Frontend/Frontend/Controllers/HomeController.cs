using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend.Services;
using Frontend.Models;

namespace Frontend.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        IActions act;

        public HomeController(IActions act)
        {
            this.act = act;
        }

        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int intToDouble)
        {
            if (intToDouble.ToString() == null || intToDouble == 0)
            {
                string message = "no input";
                return Json(message);
            }
            else
            {
                DoublingDTO num = new DoublingDTO { Received = intToDouble, Result = act.Double(intToDouble) };
                return Json(num);
            }
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeting(string Name)
        {
            
            if (Name != null)
            {
                GreeterDTO greet = new GreeterDTO { Message = act.Greet(Name) };
                return Json(greet);
            }
            else
            {
                ErrorDTO error = new ErrorDTO { Error = act.ThrowError() };
                return Json(error);
            }
        }

        [HttpGet]
        [Route("/appenda/{wordToAppendTo}")]
        public IActionResult Append(string wordToAppendTo)
        {
            if (wordToAppendTo != null)
            {
                AppendDTO app = new AppendDTO { Appended = act.AppendA(wordToAppendTo) };
                return Json(app);
            }
            else
            {
                ErrorDTO error = new ErrorDTO { Error = act.ThrowError() };
                return Json(error);
            }
        }

        [HttpPost]
        [Route("/dountil/sum/{what}")]
        public IActionResult Sum(int what)
        {
            NumberDTO num = new NumberDTO { In = what, Out = act.Sum(what) };
            return Json(num);
        }

    }
}