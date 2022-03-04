using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Product;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Config;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Product.Interfaces;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Product
{
    public class ProductRepository : IGenericRepository<ProductEntity>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
