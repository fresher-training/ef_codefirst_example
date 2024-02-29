using Microsoft.EntityFrameworkCore;
using Entitiy;

namespace PostgreSQLDatabase
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDeails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder
                .UseNpgsql("Host=ep-broad-hill-a1h75n8q.ap-southeast-1.aws.neon.tech;Database=assignment1;Username=testdevvn1989;Password=3MOnLWSAw1Px");
        }
    }
}
