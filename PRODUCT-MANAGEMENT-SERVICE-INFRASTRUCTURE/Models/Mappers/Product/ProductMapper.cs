using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Product;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models.Mappers.Product
{
    public class ProductMapper : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.Property(x => x.ID)
                   .HasColumnType("varchar(36)");

            builder.Property(x => x.RegistredDate)
                    .HasColumnType("DATETIME");

        }
    }
}
