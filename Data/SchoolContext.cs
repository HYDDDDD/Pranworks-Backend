using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Sex> Sex { get; set; }
        public DbSet<GradeClass> GradeClasse { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
