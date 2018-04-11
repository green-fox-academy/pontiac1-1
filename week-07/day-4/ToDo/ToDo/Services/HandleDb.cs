using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;
using ToDo.Entities;

namespace ToDo.Services
{
    public class HandleDb : IToDo
    {

        ToDoContext _context;

        public HandleDb(ToDoContext context)
        {
            this._context = context;
        }

        public void AddToDo(ToDos a)
        {
            using (_context)
            {
                _context.ToDo.Add(new ToDos { Content = a.Content, Priority = a.Priority });
                _context.SaveChanges();
            }
        }

        public void DelToDo(string content = null, int id = 0)
        {
            ToDos toDelete = _context.ToDo.FirstOrDefault(td => td.ID == id);
            _context.ToDo.Remove(toDelete);
            _context.SaveChanges();
        }

        public void Read(string content)
        {
            throw new NotImplementedException();
        }

        public void ReadAll()
        {
            using (_context)
            {
                _context.ToDo.ToList();
            }
        }
    }
}
