using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamPractice.Models;
using ExamPractice.Entities;

namespace ExamPractice.Controllers
{
    [Route("")]
    public class SpaceController : Controller
    {
        DataContext data;

        public SpaceController(DataContext data)
        {
            this.data = data;
        }

        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(data.Planets.ToList());
        }


    }
}