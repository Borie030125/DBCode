using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DBCode.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBCode.Data
{

    public class DBCodeContext : DbContext
    {
        public DBCodeContext (DbContextOptions<DBCodeContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Todd", City = "Cincinnati", Age = 20 },
                new Student { Id = 2, Name = "Bob", City = "Cincinnati", Age = 19 }
                );
        }

        public DbSet<DBCode.Models.Student> Student { get; set; } = default!;
    }
}
