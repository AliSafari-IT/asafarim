using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace ASafariM.Application.Utils;

public static class PasswordHasher
{
    public static string HashPassword(string password)
    {
        byte[] salt = new byte[16];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }

        using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
        {
            byte[] hash = pbkdf2.GetBytes(32);
            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 32);
            return Convert.ToBase64String(hashBytes);
        }
    }

    public static bool VerifyPassword(string password, string storedHash)
    {
        // Check for null or empty stored hash
        if (string.IsNullOrWhiteSpace(storedHash))
        {
            throw new ArgumentException("Stored hash cannot be null or empty", nameof(storedHash));
        }

        // Attempt to decode the Base64 string
        byte[] hashBytes;
        try
        {
            hashBytes = Convert.FromBase64String(storedHash);
        }
        catch (FormatException)
        {
            throw new ArgumentException(
                "Stored hash is not in a valid Base64 format",
                nameof(storedHash)
            );
        }

        // Extract the salt and hash from the combined bytes
        if (hashBytes.Length != 48) // 16 bytes salt + 32 bytes hash
        {
            throw new ArgumentException(
                "Stored hash length does not match the expected length.",
                nameof(storedHash)
            );
        }

        byte[] salt = new byte[16];
        byte[] storedHashBytes = new byte[32];
        Array.Copy(hashBytes, 0, salt, 0, 16);
        Array.Copy(hashBytes, 16, storedHashBytes, 0, 32);

        // Compute the hash of the input password with the extracted salt
        using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
        {
            byte[] computedHash = pbkdf2.GetBytes(32);
            
            // Compare the computed hash with the stored hash
            return computedHash.SequenceEqual(storedHashBytes);
        }
    }

    public static byte[] ComputeHash(string password)
    {
        using var sha256 = SHA256.Create();
        return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
}
