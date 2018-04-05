using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Services
{
    public class HandleToDo : IToDo
    {
        public void AddToDo(ToDos a)
        {
            ToDoList.myList.Add(a);
        }

        public void DelToDo(ToDos a)
        {
            ToDoList.myList.Remove(a);
        }
    }
}
