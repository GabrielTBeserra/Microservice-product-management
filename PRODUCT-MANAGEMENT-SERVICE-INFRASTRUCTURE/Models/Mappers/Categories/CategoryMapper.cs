using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Category;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models.Mappers.Categories
{
    public class CategoryMapper : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {

        }
    }
}
