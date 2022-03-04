using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Category.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Config.Interfaces;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Category.Interfaces
{
    public interface ICategoryUnitOfWork : IBaseConfigUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
    }
}
