using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations;

namespace BikeStore_WebApi.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        public string PasswordHash { get; set; }

        [Required]
        public string Role { get; set; }  // "Customer" or "Admin"

        // Navigation properties
        public ICollection<Order> Orders { get; set; }
        public ICollection<ShoppingCart> ShoppingCartItems { get; set; }
    }
}
