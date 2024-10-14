using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BikeStore_WebApi.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

    [Required(ErrorMessage = "Product Name is required.")]
    [StringLength(100, ErrorMessage = "Product Name cannot exceed 100 characters.")]
    public string Name { get; set; }

    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
    public string Description { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
    public decimal Price { get; set; }

    [Required]
    public int CategoryId { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Stock Quantity must be non-negative.")]
    public int StockQuantity { get; set; }

    // Navigation properties
    public Category Category { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
    public ICollection<ShoppingCart> ShoppingCartItems { get; set; }
}
}
