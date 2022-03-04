using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Category.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Product.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Config.Interfaces;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Product.Interfaces
{
    public interface IProductUnitOfWork : IBaseConfigUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
    }
}
