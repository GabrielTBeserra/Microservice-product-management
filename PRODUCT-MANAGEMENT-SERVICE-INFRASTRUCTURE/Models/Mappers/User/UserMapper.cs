using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.User;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models.Mappers.User
{
    public class UserMapper : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasIndex(x => x.Email).IsUnique();
        }
    }
}
