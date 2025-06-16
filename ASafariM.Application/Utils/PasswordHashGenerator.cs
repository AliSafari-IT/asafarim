using ASafariM.Application.Utils;
using System;

namespace ASafariM.Utils
{
    /// <summary>
    /// Utility class for generating BCrypt password hashes for database fixes
    /// </summary>
    public static class PasswordHashGenerator
    {
        /// <summary>
        /// Generates a BCrypt hash for a given password
        /// Usage: dotnet run --project ASafariM.Api -- generate-hash "your_password_here"
        /// </summary>
        public static void GenerateHash(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Error: Password cannot be empty");
                return;
            }

            try
            {
                var hash = PasswordHasher.HashPassword(password);
                Console.WriteLine($"Password: {password}");
                Console.WriteLine($"BCrypt Hash: {hash}");
                Console.WriteLine($"SQL Update: UPDATE Users SET PasswordHash = '{hash}' WHERE Email = 'user@example.com';");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating hash: {ex.Message}");
            }
        }

        /// <summary>
        /// Verifies a password against a hash
        /// </summary>
        public static void VerifyHash(string password, string hash)
        {
            try
            {
                var isValid = PasswordHasher.VerifyPassword(password, hash);
                Console.WriteLine($"Password: {password}");
                Console.WriteLine($"Hash: {hash}");
                Console.WriteLine($"Valid: {isValid}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error verifying hash: {ex.Message}");
            }
        }
    }
}
