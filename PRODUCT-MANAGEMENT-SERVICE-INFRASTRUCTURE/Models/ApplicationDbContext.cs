using Microsoft.EntityFrameworkCore;
using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Category;
using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Product;

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
        public DbSet<ProductEntity> ProductEntities { get; set; }
        public DbSet<CategoryEntity> CategoryEntities { get; set; }
        public DbSet<CategoryProductEntity> CategoryProductEntity { get; set; }
        public DbSet<ProductHistoryEntity> ProductHistoryEntity { get; set; }

    }
}
