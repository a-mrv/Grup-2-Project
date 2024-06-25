using EFCore.Console.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Console.Contexts
{
    public class AppDbContext:DbContext
    {
        public DbSet<Student>Students { get; set; }
        public DbSet<Lecture>Lectures { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyFirstDb");
        }
    }
}
