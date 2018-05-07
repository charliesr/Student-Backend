using Microsoft.EntityFrameworkCore;
using StudentApp.Backend.Common.Logic;

namespace StudentApp.Backend.Repository.Logic.DataBaseContexts
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppConfiguration.GetConnectionString(GetType()));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
