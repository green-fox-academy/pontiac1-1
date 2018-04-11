using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDo.Models;
using ToDo.Services;
using ToDo.Migrations;
using ToDo.Entities;

namespace ToDo.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ToDoContext _context;
        IToDo todoInter;

        public ToDoController(IToDo todoInterface, ToDoContext context)
        {
            this.todoInter = todoInterface;
            _context = context;
        }

        [Route("Test")]
        public IActionResult Test()
        {
            return View(_context.ToDo.ToList());
        }

        [Route("TestDel")]
        public IActionResult TestDel(int id)
        {
            todoInter.DelToDo(null, id);
            return Redirect("Test");
        }

        [Route("TestAdd")]
        public IActionResult TestAdd(string content, bool priority)
        {
            todoInter.AddToDo(new ToDos { Content = content, Priority = priority });
            return Redirect("Test");
        }

        [Route("Edit")]
        public IActionResult Edit(int id)
        {
            ToDos toUpdate = _context.ToDo.FirstOrDefault(td => td.ID == id);
            return View(toUpdate);
        }

        [Route("Save")]
        public IActionResult Test(int id, string newContent, bool newPriority)
        {
            using (_context)
            {
                ToDos toUpdate = _context.ToDo.FirstOrDefault(td => td.ID == id);
                toUpdate.Content = newContent;
                toUpdate.Priority = newPriority;
                _context.SaveChanges();
            }

            return Redirect("Test");
        }
    }
}
