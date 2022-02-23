using System;

namespace PRODUCT_MANAGEMENT_SERVICE_COMMON.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
