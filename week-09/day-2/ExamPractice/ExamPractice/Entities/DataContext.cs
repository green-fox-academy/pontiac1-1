using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamPractice.Models;
using JetBrains.Annotations;

namespace ExamPractice.Entities
{
    public class DataContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Spaceship> Spaceships { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
