using PRODUCT_MANAGEMENT_SERVICE_CROSSCUTING.DTO.Product;
using System.Threading.Tasks;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Product.Interfaces
{
    public interface IProductApplicationService
    {
        Task Create(ProductCreateDTO dto);
    }
}
