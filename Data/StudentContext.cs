using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentManagement.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        // Parameterless constructor (optional)
        public StudentContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If no options have been configured, use the default connection string.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StudentManagementDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the one-to-one relationship if necessary
            modelBuilder.Entity<Department>()
                .HasOne(d => d.DepartmentHead)
                .WithMany() // Assuming an instructor can be a department head for only one department
                .HasForeignKey(d => d.DepartmentHeadId);
        }
    }
}
