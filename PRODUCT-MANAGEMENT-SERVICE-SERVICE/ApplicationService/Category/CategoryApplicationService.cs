using Microsoft.EntityFrameworkCore;
using PRODUCT_MANAGEMENT_SERVICE_COMMON.Exceptions;
using PRODUCT_MANAGEMENT_SERVICE_COMMON.Helpers.StringContext;
using PRODUCT_MANAGEMENT_SERVICE_CROSSCUTING.DTO.Category;
using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Category;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Category.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Category.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Category
{
    public class CategoryApplicationService : ICategoryApplicationService
    {
        private readonly ICategoryUnitOfWork _uow;

        public CategoryApplicationService(ICategoryUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task Create(CategoryPostDTO dto)
        {
            bool alreadyExists = _uow.CategoryRepository.GetUntracked().Any(x => x.Name.ToLower() == dto.Name.ToLower().Sanatize());

            if (alreadyExists)
            {
                throw new DomainException("Category already exists");
            }

            CategoryEntity categoryEntity = new CategoryEntity
            {
                Name = dto.Name.Sanatize(),
                TAG = dto.TAG
            };

            await _uow.CategoryRepository.AddAsync(categoryEntity);
            await _uow.CommitAsync();
        }

        public async Task<IEnumerable<ListCategoriesDTO>> GetAll()
        {
            var allCategories = await _uow.CategoryRepository.GetUntracked().Select(x => new ListCategoriesDTO
            {
                Name = x.Name,
                Tag = x.TAG
            }).ToListAsync();

            return allCategories;
        }
    }
}
