using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend.Services;
using Frontend.Models;
using System.Net.Mail;

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
        [Route("/dountil/{what}")]
        public IActionResult FactorOrSum(string what, [FromBody]NumberDTO until)
        {
            if (what == "sum")
            {
                return Json(new { Result = act.Sum(until.Until) });
            }
            else if (what == "factor")
            {
                return Json(new { Result = act.Factor(until.Until) });
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [Route("/arrays")]
        public IActionResult Array([FromBody]Arrays array)
        {
            if (array.What == "sum")
            {
                return Json(act.SumArr(array.Numbers));
            }
            else if(array.What == "factor")
            {
                return Json(act.MultiplyArr(array.Numbers));
            }
            else
            {
                return Json(act.DoubleArr(array.Numbers));
            }
        }

    }
}