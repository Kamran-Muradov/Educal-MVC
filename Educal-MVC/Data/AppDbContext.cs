using Educal_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Educal_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseImage> CourseImages { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
    }
}
