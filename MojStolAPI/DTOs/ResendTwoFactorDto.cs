using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class ResendTwoFactorDto
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public required string Email { get; set; }
    }
}