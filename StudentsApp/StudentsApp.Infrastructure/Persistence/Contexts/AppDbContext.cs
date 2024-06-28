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
        DbSet<Student> Students {  get; set; }
        DbSet<Lecture> Lectures {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = localhost; Port = 5432; Database = myDataBase; User Id = myUsername; Password = mysecretpassword;");
        }
        // veri tabanı tabloları

        // override onconfiguring
        // usenpgsql
        // bağlantı adresi
    }
}
