using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PRODUCT_MANAGEMENT_SERVICE_INFRASTRUCTURE.Models;
using System;

namespace PRODUCT_MANAGEMENT_SERVICE_SERVICE.DependencyInjection
{
    public static class ConfigureBindingsDatabaseContext
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("mysqllocalhost");

            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 5))));
        }
    }
}