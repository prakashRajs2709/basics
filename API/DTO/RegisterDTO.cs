using System.ComponentModel.DataAnnotations;

namespace API;

public class RegisterDTO
{
    [Required]
    [MaxLength(50)]
    [MinLength(3)]
    public required string Username { get; set; } = string.Empty;
    public required string Password { get; set; } = string.Empty;
}