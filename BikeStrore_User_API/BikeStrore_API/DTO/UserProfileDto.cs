using System.ComponentModel.DataAnnotations;

namespace BikeStrore_API.DTO
{
    public class UserProfileDto
    {
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
