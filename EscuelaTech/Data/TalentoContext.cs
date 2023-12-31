﻿using EscuelaTech.Models;
using Microsoft.EntityFrameworkCore;


namespace EscuelaTech.Data
{

    public class TalentoContext : DbContext
    {
        public TalentoContext(DbContextOptions<TalentoContext> options) : base(options) { }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}


