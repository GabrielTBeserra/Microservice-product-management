using Microsoft.AspNetCore.Http;

namespace PRODUCT_MANAGEMENT_SERVICE_COMMON.Configurations.Http
{
    public static class HttpContextGetter
    {
        public static IHttpContextAccessor ContextAcessor;

        public static void Configure(IHttpContextAccessor acessor)
        {
            ContextAcessor = acessor;
        }
    }
}
