using Microsoft.EntityFrameworkCore;
using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.User;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        // public DbSet<UserEntity> Users { get; set; }

    }
}
