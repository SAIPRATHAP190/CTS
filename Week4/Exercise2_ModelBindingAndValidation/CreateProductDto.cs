using System.ComponentModel.DataAnnotations;

namespace InventoryApi.DTOs
{
    public class CreateProductDto
    {
        [Required(ErrorMessage = "Product Name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; } = string.Empty;

        [Range(0.01, 100000.00, ErrorMessage = "Price must be between $0.01 and $100,000.00")]
        public decimal Price { get; set; }

        [Range(0, 1000, ErrorMessage = "Stock count must be a non-negative integer up to 1000.")]
        public int Stock { get; set; }
    }
}
