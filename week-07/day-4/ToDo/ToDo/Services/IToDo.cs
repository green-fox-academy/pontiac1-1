using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Services
{
    public interface IToDo
    {
        void AddToDo(ToDos a);
        void DelToDo(ToDos a);
    }
}
