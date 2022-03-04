using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Product;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Category
{
    public class CategoryProductEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("product_id")]
        public Guid ProductId { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }
        public virtual ProductEntity Product { get; set; }
        public virtual CategoryEntity Category { get; set; }
    }
}
