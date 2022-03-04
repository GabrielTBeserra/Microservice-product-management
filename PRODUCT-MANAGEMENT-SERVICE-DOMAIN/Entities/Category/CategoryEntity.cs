using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRODUCT_MANAGEMENT_SERVICE_DOMAIN.Entities.Category
{
    [Table("Categories")]
    public class CategoryEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("tag")]
        [Required]
        public string TAG { get; set; }
        public virtual ICollection<CategoryProductEntity> CategoryProduct { get; set; }

    }
}
