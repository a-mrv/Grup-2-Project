using GPTClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTClone.Infrastructure.Contexts
{
    public class GPTCloneDbContext:DbContext
    {
        public DbSet<Prompt> Prompts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=GPTCloneDb;User Id=postgres;Password=mysecretpassword;");
        }
    }
}
