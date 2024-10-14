using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BikeStore_WebApi.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total Price must be greater than 0.")]
        public decimal TotalPrice { get; set; }

        [Required]
        public string OrderStatus { get; set; }  // "Pending", "Shipped", "Delivered", "Cancelled"

        // Navigation properties
        public User User { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
