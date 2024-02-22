using EFCoreFirstExample.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCoreFirstExample
{
    public class EFCoreFirstExampleDBContext : DbContext
    {
        private string _ConnectionString = "Host=ep-broad-hill-a1h75n8q.ap-southeast-1.aws.neon.tech;Database=assignment1;Username=testdevvn1989;Password=3MOnLWSAw1Px";
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(_ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasOne(a => a.UserDetail)
                .WithOne(a => a.User)
                .HasForeignKey<UserDetail>(a => a.UserId);
        }
    }
}
