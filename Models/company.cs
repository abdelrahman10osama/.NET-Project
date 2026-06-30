using Microsoft.EntityFrameworkCore;
namespace WebApplication2.Models
{
    public class company : DbContext
    {
        public DbSet<department> Departments { get; set; }
        public DbSet<instructor> Instructors { get; set; }
        public DbSet<trainee> Trainees { get; set; }
        public DbSet<course> Courses { get; set; }
        public DbSet<crsResult> CrsResult { get; set; }
        public DbSet<User> Users { get; set; }
        public company(DbContextOptions<company> options)
            : base(options)
        {
        }
       
    }
}
