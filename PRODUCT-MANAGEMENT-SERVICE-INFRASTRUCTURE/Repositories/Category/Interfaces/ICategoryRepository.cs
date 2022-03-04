using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Category;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Config.Interfaces;

namespace PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Category.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<CategoryEntity>
    {
    }
}
