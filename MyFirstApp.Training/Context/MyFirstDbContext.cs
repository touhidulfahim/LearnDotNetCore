using Microsoft.EntityFrameworkCore;
using MyFirstApp.Training.Entities;

namespace MyFirstApp.Training.Context
{
    public class MyFirstDbContext:DbContext, IMyFirstDbContext
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

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
