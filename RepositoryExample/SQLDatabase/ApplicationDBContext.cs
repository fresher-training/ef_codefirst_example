using Microsoft.EntityFrameworkCore;
using Entitiy;

namespace SQLDatabase
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDeails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder
                .UseSqlServer("Server=sql.bsite.net\\MSSQL2016;Database=appuser1001_advance_csharp;User Id=appuser1001_advance_csharp;Password=abcd123456;Trusted_Connection=False;TrustServerCertificate=True");
        }
    }
}
