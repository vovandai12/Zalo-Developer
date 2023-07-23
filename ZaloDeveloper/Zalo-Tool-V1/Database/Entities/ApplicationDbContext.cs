using Microsoft.EntityFrameworkCore;

namespace Zalo_Tool_V1.Database.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(e => e._Id);
        }
        public DbSet<User> Users { get; set; }
    }
}
