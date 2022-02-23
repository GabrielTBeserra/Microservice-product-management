using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.User;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Config;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.User.Interfaces;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.User
{
    public class UserRepository : GenericRepository<UserEntity>, IUserRepository
    {
        public UserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
