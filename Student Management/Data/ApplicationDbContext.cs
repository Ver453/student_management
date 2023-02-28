using Student_Management.Models;
namespace Student_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<StudentModel> students { get; set; }
        public DbSet<FacultyModel> faculties { get; set; }
    }
}