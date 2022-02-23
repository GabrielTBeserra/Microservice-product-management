using System;

namespace PRODUCT_MANAGEMENT_SERVICE_COMMON.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
