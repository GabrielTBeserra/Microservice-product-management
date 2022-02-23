using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.DependencyInjection.ApplicationServiceInjection;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.DependencyInjection.RepositoryInjection;
using PRODUCT_MANAGEMENT_SERVICE_SERVICE.DependencyInjection.UnitOfWorkInjection;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.DependencyInjection
{
    public static class ConfigureBindingsDependencyInjection
    {

        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureBindingsApplicationService.RegisterBindings(services, configuration);
            ConfigureBindingsRepository.RegisterBindings(services, configuration);
            ConfigureBindinsUnifOfWorks.RegisterBindings(services, configuration);
        }
    }
}