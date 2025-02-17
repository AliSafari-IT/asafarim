using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ASafariM.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ASafariM.Application.Services
{
    public class JwtTokenService
    {
        private readonly IConfiguration _configuration;

        public JwtTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(
                _configuration["Jwt:Key"]
                    ?? throw new InvalidOperationException("JWT key is not configured")
            );

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(
                            ClaimTypes.Role,
                            user.IsAdmin ? "Admin"
                                : user.IsSuperAdmin ? "SuperAdmin"
                                : user.IsModerator ? "Moderator"
                                : user.IsEditor ? "Editor"
                                : user.IsGuest ? "Pending"
                                : user.IsBannedByAdmin ? "BannedByAdmin"
                                : user.IsBlocked ? "Blocked"
                                : "User"
                        ),
                    }
                ),
                Expires = DateTime.UtcNow.AddMinutes(
                    Convert.ToInt32(_configuration["Jwt:ExpiresInMinutes"])
                ),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                ),
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
