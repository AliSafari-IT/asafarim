using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

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
        if (string.IsNullOrEmpty(password))
            throw new ArgumentException("Password cannot be null or empty", nameof(password));
        if (string.IsNullOrEmpty(storedHash))
            throw new ArgumentException("Stored hash cannot be null or empty", nameof(storedHash));

        try
        {
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Invalid hash format or failed to verify password", nameof(storedHash), ex);
        }
    }
}
