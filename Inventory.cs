using System.ComponentModel.DataAnnotations;

namespace BikeStore_WebApi.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; } = 0;

        public DateTime? RestockDate { get; set; }

        // Navigation Properties
        public Product Product { get; set; }
    }
}
