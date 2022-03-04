using PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Product
{
    [Table("Product")]
    public class ProductEntity
    {
        [Key]
        [Column("id")]
        public Guid ID { get; set; }

        [Column("Identify")]
        [Required]
        public string Identify { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        [Required]
        public DateTime RegistredDate { get; set; }

        public virtual ICollection<CategoryProductEntity> CategoryProduct { get; set; }

        public virtual ICollection<ProductHistoryEntity> ProductHistory { get; set; }

    }
}
