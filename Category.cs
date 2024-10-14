using System.ComponentModel.DataAnnotations;

namespace BikeStore_WebApi.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Category Name cannot exceed 100 characters.")]
        public string CategoryName { get; set; }

        // Navigation properties
        public ICollection<Product> Products { get; set; }
    }
}
