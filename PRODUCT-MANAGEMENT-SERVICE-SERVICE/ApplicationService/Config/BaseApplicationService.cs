using Microsoft.EntityFrameworkCore;
using PRODUCT_MANAGEMENT_SERVICE_COMMON.Exceptions;
using PRODUCT_MANAGEMENT_SERVICE_COMMON.Helpers.HttpContext;
using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.User;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Base.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Config.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Config
{
    public class BaseApplicationService : IBaseApplicationService
    {
        protected readonly IBaseUnitOfWork BaseUnitOfWork;

        public BaseApplicationService(IBaseUnitOfWork unitOfWork)
        {
            BaseUnitOfWork = unitOfWork;
        }

        public async Task<UserEntity> GetLoggedUserTracked()
        {
            var loggedUserName = HttpHelper.LoggedUser;
            var user = await BaseUnitOfWork.UserRepository.GetTracked().Where(x => x.Email == loggedUserName).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new DomainException("User not found");
            }

            return user;
        }


        public async Task<UserEntity> GetLoggedUserUntracked()
        {
            var loggedUserName = HttpHelper.LoggedUser;
            var user = await BaseUnitOfWork.UserRepository.GetTracked().Where(x => x.Email == loggedUserName).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new DomainException("User not found");
            }

            return user;
        }


    }
}
