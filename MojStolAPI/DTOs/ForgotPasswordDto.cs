using System.ComponentModel.DataAnnotations;

namespace DTO {
  public class ForgotPasswordDto {
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public required string Email { get; set; }
  }
}