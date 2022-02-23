using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.User;
using System.Threading.Tasks;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Config.Interfaces
{
    public interface IBaseApplicationService
    {
        Task<UserEntity> GetLoggedUserUntracked();
        Task<UserEntity> GetLoggedUserTracked();
    }
}
