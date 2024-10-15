using System.ComponentModel.DataAnnotations;

namespace BikeStrore_API.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }  // Storing password as plain text (not recommended)
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string Role { get; set; }// Role (Admin/User)
    }
}
