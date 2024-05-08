using Microsoft.EntityFrameworkCore;
using Session3.Models;

namespace Session3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=studentCrud;trusted_connection=true;trustServerCertificate=true");
        }
    }
}
