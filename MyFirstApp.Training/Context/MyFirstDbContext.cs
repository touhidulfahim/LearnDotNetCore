using Microsoft.EntityFrameworkCore;
using MyFirstApp.Training.Entities;

namespace MyFirstApp.Training.Context
{
    public class  MyFirstDbContext:DbContext, IMyFirstDbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public MyFirstDbContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many relationship
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Topics)
                .WithOne(t => t.Courses);

            modelBuilder.Entity<CourseStudent>()
                .HasKey(cs => new {cs.CourseId, cs.StudentId});

            modelBuilder.Entity<CourseStudent>()
                .HasOne(cs=>cs.Courses)
                .WithMany(c => c.EnrolledStudents)
                .HasForeignKey(cs => cs.CourseId);

            modelBuilder.Entity<CourseStudent>()
                .HasOne(cs=>cs.Students)
                .WithMany(s => s.EnrolledCourses)
                .HasForeignKey(cs => cs.StudentId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
