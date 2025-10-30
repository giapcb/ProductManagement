using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(3)]
        public string? Name { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be > 0")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stock must be >= 0")]
        public int Stock { get; set; }

        public string? Description { get; set; }
    }
}
