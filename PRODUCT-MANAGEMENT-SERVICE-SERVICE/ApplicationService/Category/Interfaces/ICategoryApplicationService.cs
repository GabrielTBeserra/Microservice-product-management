using PRODUCT_MANAGEMENT_SERVICE_CROSSCUTING.DTO.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Category.Interfaces
{
    public interface ICategoryApplicationService
    {
        Task Create(CategoryPostDTO dto);
        Task<IEnumerable<ListCategoriesDTO>> GetAll();
    }
}
