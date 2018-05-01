using Microsoft.EntityFrameworkCore;
using Yk.School.Models;

namespace Yk.School.EntityFramework
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }


        public DbSet<Student> Students { get; set; }

        public DbSet<DanceClass> DanceClasses { get; set; }
        public DbSet<Instructor> IdInstructors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FeeHistory> FeeHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<DanceClass>().ToTable("DanceClass");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<FeeHistory>().ToTable("FeeHistory");
        }
    }
}