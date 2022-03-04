using Microsoft.EntityFrameworkCore;
using PRODUCT_MANAGEMENT_SERVICE_CROSSCUTING.DTO.Product;
using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Category;
using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Product;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Product.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Product.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Product
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductUnitOfWork _uow;

        public ProductApplicationService(IProductUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task Create(ProductCreateDTO dto)
        {
            var categories = _uow.CategoryRepository.GetTracked().Where(x => dto.Categories.Contains(x.Id));

            var guid = Guid.NewGuid();

            var product = new ProductEntity
            {
                Description = dto.Description,
                Name = dto.Name,
                Identify = guid.ToString().Split("-")[0],
                ID = guid,
                Price = dto.Price,
                CategoryProduct = await categories.Select(x => new CategoryProductEntity
                {
                    CategoryId = x.Id,
                }).ToListAsync(),
            };

            await _uow.ProductRepository.AddAsync(product);
            await _uow.CommitAsync();
        }
    }
}
