using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;
using ToDo.Services;

namespace ToDo.Controllers
{
    public class ToDoController : Controller
    {
        IToDo todoInter;

        public ToDoController(IToDo todoInterface)
        {
            this.todoInter = todoInterface;
        }

        [Route("List")]
        public IActionResult List()
        {
            todoInter.ReadAll();
            return View((object)ToDoList.myList);
        }

        [Route("Add")]
        public IActionResult List(string content, bool priority)
        {
            todoInter.AddToDo(new ToDos { Content = content, Priority = priority });
            todoInter.Read();
            return View((object)ToDoList.myList);
            
        }

        [Route("Del")]
        public IActionResult List(int index)
        {
            todoInter.DelToDo(ToDoList.myList[index]);
            return View(ToDoList.myList);
        }

        //[Route("Save")]
        //public IActionResult Save(int index)
        //{
            
        //    return View("saved");
        //}
    }
}
