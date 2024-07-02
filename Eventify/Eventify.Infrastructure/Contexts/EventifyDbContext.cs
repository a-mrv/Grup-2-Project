using Eventify.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Infrastructure.Contexts
{
    public class EventifyDbContext:DbContext
    {
        public DbSet<Event>Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=EventifyDb;User Id=postgres;Password=mysecretpassword;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Event>()
                .OwnsOne(e=>e.Location);

           
        }
    }
}
