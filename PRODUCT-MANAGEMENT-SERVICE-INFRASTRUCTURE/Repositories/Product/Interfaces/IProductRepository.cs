using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Product;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Config.Interfaces;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Product.Interfaces
{
    public interface IProductRepository : IGenericRepository<ProductEntity>
    {
    }
}
