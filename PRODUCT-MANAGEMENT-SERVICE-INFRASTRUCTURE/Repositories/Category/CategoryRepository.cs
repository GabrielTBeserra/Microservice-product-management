using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Category;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Category.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Config;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Category
{
    public class CategoryRepository : IGenericRepository<CategoryEntity>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
