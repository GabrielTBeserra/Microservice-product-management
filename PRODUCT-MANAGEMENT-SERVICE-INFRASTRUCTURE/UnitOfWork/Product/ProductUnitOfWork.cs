using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Category.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Product.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Config;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Product.Interfaces;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Product
{
    public class ProductUnitOfWork : BaseConfigUnitOfWork, IProductUnitOfWork
    {
        public ProductUnitOfWork(ApplicationDbContext applicationDbContext, IProductRepository productRepository, ICategoryRepository categoryRepository) : base(applicationDbContext)
        {
            ProductRepository = productRepository;
            CategoryRepository = categoryRepository;
        }

        public IProductRepository ProductRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
    }
}
