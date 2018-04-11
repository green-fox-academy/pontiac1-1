using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Entities

{
    public class ToDoContext : DbContext
    {
        
        public DbSet<ToDos> ToDo { get; set; }

        public ToDoContext(DbContextOptions<ToDoContext> context) : base(context)
        {
        }
    }
}
