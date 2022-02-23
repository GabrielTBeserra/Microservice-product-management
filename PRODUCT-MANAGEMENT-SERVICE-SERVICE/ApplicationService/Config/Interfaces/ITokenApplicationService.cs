using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.User;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Config.Interfaces
{
    public interface ITokenApplicationService
    {
        string GenerateToken(UserEntity user);
    }
}
