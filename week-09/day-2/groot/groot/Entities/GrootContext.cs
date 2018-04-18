using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace groot.Entities
{
    public class GrootContext : DbContext
    {
        public GrootContext(DbContextOptions<GrootContext> options) : base(options)
        {
        }
    }
}
