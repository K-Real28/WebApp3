using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApp3.Domains;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApp3
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Special> Specials { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
