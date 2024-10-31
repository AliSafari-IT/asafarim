using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DashboardApi.Core.Domain.Entities; // Assuming this is your User entity namespace
using Microsoft.AspNetCore.Identity;
using System.Linq;
using DashboardApi.Core.Domain.Models;
using DashboardApi.Infrastructure.Data;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace DashboardApi.WebApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;
        private readonly PasswordHasher<User> _passwordHasher;

        public AuthController(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
            _passwordHasher = new PasswordHasher<User>();
        }

        [HttpPost("login", Name = "Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Find the user in the database
            var user = _context.Users.SingleOrDefault(u => u.Username == request.Username);
            if (user == null)
            {
                return Unauthorized("Invalid username or password.");
            }

            var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);
            if (passwordVerificationResult != PasswordVerificationResult.Success)
            {
                // Log invalid attempts
                Console.WriteLine($"{request.Username} → {request.Password} → user.PasswordHash: {user.PasswordHash} passwordVerificationResult: {passwordVerificationResult}");
                return Unauthorized("Invalid username or password.");
            }

            // Generate token and return the current authenticated User with token
            var token = GenerateJwtToken(user);
            var currentUserWithToken = new { username = user.Username, token };

            // Return the current authenticated User with token
            return Ok(new { currentUserWithToken });
        }

        private string GenerateJwtToken(User user)
        {
            var jwtSettings = _configuration.GetSection("Jwt");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"])); // Retrieve the key from appsettings.json
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Add claims based on user's roles
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(double.Parse(jwtSettings["ExpiresInMinutes"])),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
