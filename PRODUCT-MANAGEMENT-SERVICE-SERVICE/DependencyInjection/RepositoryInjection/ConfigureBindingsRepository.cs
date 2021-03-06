using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Category;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Category.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Product;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.Product.Interfaces;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.User;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Repositories.User.Interfaces;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.DependencyInjection.RepositoryInjection
{
    public static class ConfigureBindingsRepository
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }

    }
}
