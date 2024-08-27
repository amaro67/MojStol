using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class UserLoginDto
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public required string Email { get; set; }
        public required string Password { get; set; }
    }

}