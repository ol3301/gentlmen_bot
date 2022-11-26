using Microsoft.EntityFrameworkCore;
using System;

namespace GentlmenBot.Context
{
    public class GentlemenContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public GentlemenContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=GentlemenBot.db");
        }
    }
}
