using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class VerifyTwoFactorDto
    {
        [Required(ErrorMessage = "UserId is required.")]
        public int UserId { get; set; } // Replace email with UserId

        [Required(ErrorMessage = "You must enter the code.")]
        public required string TwoFactorCode { get; set; }
    }
}
