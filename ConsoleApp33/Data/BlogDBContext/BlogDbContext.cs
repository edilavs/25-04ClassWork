using ConsoleApp33.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp33.Data.BlogDBContext
{
    public class BlogDbContext:DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GCUJ6KM;Database=Blog;Trusted_Connection=TRUE;");
        }
    }
}
