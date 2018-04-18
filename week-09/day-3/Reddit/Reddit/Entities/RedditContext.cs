using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Reddit.Models;

namespace Reddit.Entities
{
    public class RedditContext : DbContext
    {
        public DbSet<Post> PostList { get; set; }
        public DbSet<User> UserList { get; set; }

        public RedditContext(DbContextOptions<RedditContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(p => p.MyPosts)
                .WithOne(o => o.Owner);
        }
    }
}
