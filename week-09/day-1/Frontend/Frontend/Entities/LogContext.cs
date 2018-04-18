using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;

namespace Frontend.Entities
{
    public class LogContext : DbContext
    {
        public DbSet<LogDTO> LogList { get; set; }

        public LogContext(DbContextOptions<LogContext> options) : base(options) { }

    }
}
