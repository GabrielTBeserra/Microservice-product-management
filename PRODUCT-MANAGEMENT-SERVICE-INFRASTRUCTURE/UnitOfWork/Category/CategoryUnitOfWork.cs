using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Category.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Category.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Config;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Category
{
    public class CategoryUnitOfWork : BaseConfigUnitOfWork, ICategoryUnitOfWork
    {
        public CategoryUnitOfWork(ApplicationDbContext applicationDbContext, ICategoryRepository cat) : base(applicationDbContext)
        {
            CategoryRepository = cat;
        }

        public ICategoryRepository CategoryRepository { get; }
    }
}
