namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }
    public string UserName { get; set; } = "";

    public required byte[] PasswordHash { get; set; }
    
    public required byte[] PasswordSalt { get; set; }
    // public required string UserName { get; set; } 
    // public string? UserName { get; set; } 
    // public string UserName { get; set; } = null;
    // public string UserName { get; set; } = null;  nullable should be disable api.csproj


}