using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.User;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Config.Interfaces;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.User.Interfaces
{
    public interface IUserRepository : IGenericRepository<UserEntity>
    {
    }
}
