using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend.Services;
using Frontend.Models;
using System.Net.Mail;
using Frontend.Entities;

namespace Frontend.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        IActions act;
        LogContext logger;

        public HomeController(IActions act, LogContext logger)
        {
            this.act = act;
            this.logger = logger;
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
            logger.LogList.Add(new LogDTO { createdAt = DateTime.Now, Endpoint = @"/greeter", Data = Name });
            logger.SaveChanges();

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

        [HttpGet]
        [Route("/log")]
        public IActionResult ListLog(string q)
        {
            if (q == null)
            {
            Logger toReturn = new Logger { LogList = logger.LogList.ToList(), Entries = logger.LogList.ToList().Count() };
            return Json(toReturn);

            }
            else
            {
                Logger toReturn = new Logger { LogList = logger.LogList.Where(l=>l.Data.Contains(q)).ToList(), Entries = logger.LogList.ToList().Count() };
                return Json(toReturn);
            }
        }

       
    }
}