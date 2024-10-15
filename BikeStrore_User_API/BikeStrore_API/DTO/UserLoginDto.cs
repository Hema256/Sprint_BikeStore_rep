using System.ComponentModel.DataAnnotations;

namespace BikeStrore_API.DTO
{
    public class UserLoginDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password{ get; set; }
    }
}

