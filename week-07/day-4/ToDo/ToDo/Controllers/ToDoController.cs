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
            ToDoList.myList.Clear();
            todoInter.ReadAll();
            return View((object)ToDoList.myList);
            
        }

        [Route("Del")]
        public IActionResult List(string content)
        {
            todoInter.DelToDo(content);
            ToDoList.myList.Clear();
            todoInter.ReadAll();
            return View(ToDoList.myList);
        }
    }
}
