using Microsoft.EntityFrameworkCore;
using StudentsApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.Infrastructure.Persistence.Contexts
{
    public class AppDbContext:DbContext       //kalıtım(kütüphane)
    {
       public DbSet<Student> Students {  get; set; }
       public DbSet<Lecture> Lectures {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = localhost; Port = 5432; Database = StudentsAppDb; User Id = postgres; Password = mysecretpassword;");
        }
        // veri tabanı tabloları

        // override onconfiguring
        // usenpgsql
        // bağlantı adresi
    }
}
