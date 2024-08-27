using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class ResetPasswordDto
    {
        [Required(ErrorMessage = "Token is required.")]
        public required string Token { get; set; }

        [Required(ErrorMessage = "New password is required.")]
        public required string NewPassword { get; set; }
    }
}