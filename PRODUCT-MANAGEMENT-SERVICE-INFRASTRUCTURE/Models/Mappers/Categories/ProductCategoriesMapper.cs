using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Category;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models.Mappers.Categories
{
    public class ProductCategoriesMapper : IEntityTypeConfiguration<CategoryProductEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryProductEntity> builder)
        {
            builder.HasOne(x => x.Product)
                .WithMany(x => x.CategoryProduct)
                .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.CategoryProduct)
                .HasForeignKey(x => x.CategoryId);



        }
    }
}

