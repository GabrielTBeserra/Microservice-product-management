using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Product
{
    public class ProductHistoryEntity
    {
        [Key]
        [Column("id")]
        public Guid ID { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        [Required]
        public DateTime UpdateDate { get; set; }

        public virtual ProductEntity Product { get; set; }

    }
}
