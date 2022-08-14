using System;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class BugDBContext:DbContext
    {
        public BugDBContext(DbContextOptions<BugDBContext> option) : base(option)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}

