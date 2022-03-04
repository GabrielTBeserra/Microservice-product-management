using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Category;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Category.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Config;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Config.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Product;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.ApplicationService.Product.Interfaces;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.DependencyInjection.ApplicationServiceInjection
{
    public static class ConfigureBindingsApplicationService
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITokenApplicationService, TokenApplicationService>();
            services.AddScoped<IBaseApplicationService, BaseApplicationService>();
            services.AddScoped<ICategoryApplicationService, CategoryApplicationService>();
            services.AddScoped<IProductApplicationService, ProductApplicationService>();

        }
    }
}
