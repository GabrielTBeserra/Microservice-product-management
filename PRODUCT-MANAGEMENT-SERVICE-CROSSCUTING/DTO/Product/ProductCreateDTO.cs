using System.Collections.Generic;

namespace PRODUCT_MANAGEMENT_SERVICE_CROSSCUTING.DTO.Product
{
    public class ProductCreateDTO
    {
        public string Identify { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<int> Categories { get; set; }
    }
}
