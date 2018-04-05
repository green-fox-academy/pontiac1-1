using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagram.Services;
using Microsoft.AspNetCore.Mvc;

namespace Anagram.Controllers
{
    public class AnagramController : Controller
    {
        IAnagram anagramcheck;

        public AnagramController(IAnagram anagramchecker)
        {
            this.anagramcheck = anagramchecker;
        }

        [Route("Anagram")]
        [HttpGet]
        public IActionResult Anagram()
        {
            return View();
        }

        [Route("Check")]
        [HttpPost]
        public IActionResult Check(string first, string second)
        {       
            return View((object)anagramcheck.IfAnagram(first, second));
        }
    }
}