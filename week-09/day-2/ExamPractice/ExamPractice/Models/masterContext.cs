using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExamPractice.Models
{
    public partial class masterContext : DbContext
    {
        public virtual DbSet<CampList> CampList { get; set; }
        public virtual DbSet<LogList> LogList { get; set; }
        public virtual DbSet<PostList> PostList { get; set; }
        public virtual DbSet<RaceList> RaceList { get; set; }
        public virtual DbSet<Spaceship> Spaceship { get; set; }
        public virtual DbSet<ToDo> ToDo { get; set; }
        public virtual DbSet<ToDoList> ToDoList { get; set; }
        public virtual DbSet<TourList> TourList { get; set; }

        // Unable to generate entity type for table 'dbo.planet'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=master;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<LogList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt).HasColumnName("createdAt");
            });

            modelBuilder.Entity<PostList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<RaceList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Spaceship>(entity =>
            {
                entity.ToTable("spaceship");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaxCapacity).HasColumnName("max_capacity");

                entity.Property(e => e.Planet)
                    .HasColumnName("planet")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Utilization).HasColumnName("utilization");
            });

            modelBuilder.Entity<ToDo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ToDoList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<TourList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });
        }
    }
}
