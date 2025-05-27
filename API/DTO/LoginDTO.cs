using System.ComponentModel.DataAnnotations;

namespace API.DTO;

public class LoginDTO
{
    public required string Username { get; set; } = string.Empty;
    public required string Password { get; set; } = string.Empty;
}