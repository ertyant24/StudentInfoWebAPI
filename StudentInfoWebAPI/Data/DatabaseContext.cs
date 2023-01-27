using Microsoft.EntityFrameworkCore;

namespace StudentInfoWebAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<College> Colleges { get; set; }
    }
}
