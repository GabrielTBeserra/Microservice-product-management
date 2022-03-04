using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Base;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Base.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Category;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Category.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Config;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Config.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Product;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.UnitOfWork.Product.Interfaces;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.DependencyInjection.UnitOfWorkInjection
{
    public static class ConfigureBindinsUnifOfWorks
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IBaseConfigUnitOfWork, BaseConfigUnitOfWork>();
            services.AddScoped<IBaseUnitOfWork, BaseUnitOfWork>();
            services.AddScoped<ICategoryUnitOfWork, CategoryUnitOfWork>();
            services.AddScoped<IProductUnitOfWork, ProductUnitOfWork>();
        }
    }
}
