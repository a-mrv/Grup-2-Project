using ContactDbApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDbApp.Domain.Contexts
{
    public class ContactDbAppContext: DbContext
    {
        public DbSet<Student>Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=myDataBase;User Id=postgres;Password=mysecretpassword;");
        }

    }
}
