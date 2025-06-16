using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Serilog;

namespace ASafariM.Application.Utils;

public static class PasswordHasher
{
    private const int WORK_FACTOR = 11; // Same as in the database

    public static string HashPassword(string password)
    {
        if (string.IsNullOrEmpty(password))
            throw new ArgumentException("Password cannot be null or empty", nameof(password));

        return BCrypt.Net.BCrypt.HashPassword(password, WORK_FACTOR);
    }

    public static bool VerifyPassword(string password, string storedHash)
    {
        try
        {
            // Check if the password is null or empty
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            // Check if the stored hash is null or empty
            if (string.IsNullOrWhiteSpace(storedHash))
            {
                return false;
            }

            // Verify the password against the stored hash
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }
        catch (BCrypt.Net.SaltParseException)
        {
            // Log this for monitoring corrupted password hashes
            Log.Warning(
                "BCrypt salt parse error - corrupted password hash detected. Hash: {Hash}",
                storedHash
            );
            return false;
        }
        catch (ArgumentException ex)
        {
            // Log BCrypt-related argument exceptions
            Log.Warning(
                "BCrypt argument exception during password verification: {Message}, Hash: {Hash}",
                ex.Message,
                storedHash
            );
            return false;
        }
        catch (Exception)
        {
            // Handle any other unexpected exceptions
            return false;
        }
    }
}
