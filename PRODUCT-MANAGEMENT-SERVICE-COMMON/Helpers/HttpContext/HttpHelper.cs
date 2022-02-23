using PRODUCT_MANAGEMENT_SERVICE_COMMON.Configurations.Http;

namespace PRODUCT_MANAGEMENT_SERVICE_COMMON.Helpers.HttpContext
{
    public static class HttpHelper
    {
        public static string LoggedUser
        {
            get { return HttpContextGetter.ContextAcessor.HttpContext?.User.Identity.Name; }
        }
    }
}
