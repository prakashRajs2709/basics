namespace API;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.IdentityModel.Tokens;

// Removed 'using API.Interfaces;' as 'API.Interfaces' does not exist or is not referenced
public class TokenService : ITokenService
{
    private readonly IConfiguration config;
     public TokenService(IConfiguration configu)
    {
        config = configu;
    }
    public string CreateToken(AppUser user)
    {

        var tokenkey = config["TokenKey"] ?? throw new Exception("TokenKey not found in configuration");
        if (tokenkey.Length < 64)
        {
            throw new Exception("TokenKey must be at least 64 characters long");
        }

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenkey));

        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.UserName),
        };

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
        var tokendescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = creds
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateToken(tokendescriptor);
        // This method should implement the logic to create a JWT token for the user
        // For now, we will return a placeholder string
        return tokenHandler.WriteToken(token); // Replace with actual token generation logic
    }

}