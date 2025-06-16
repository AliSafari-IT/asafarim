-- Fix corrupted password hashes
-- This script will reset passwords for users with corrupted BCrypt hashes

-- First, let's identify users with corrupted hashes
-- BCrypt hashes should start with $2a$, $2b$, $2x$, or $2y$
SELECT 
    Id, 
    UserName, 
    Email, 
    PasswordHash,
    CASE 
        WHEN PasswordHash NOT LIKE '$2_$%' THEN 'CORRUPTED'
        ELSE 'VALID'
    END AS HashStatus
FROM Users 
WHERE PasswordHash NOT LIKE '$2_$%';

-- Reset password for demo_admin to 'TempPass123!' (BCrypt hashed)
-- You can generate this hash by running: BCrypt.Net.BCrypt.HashPassword("TempPass123!", 11)
-- The hash below is for 'TempPass123!' with work factor 11
UPDATE Users 
SET PasswordHash = '$2a$11$rQOHNGjgfuVPfefL1cHmrOzXpQm1ZdGa6Q8SU8K5YzQ2XqVHl8sGi'
WHERE Email = 'demo_admin@example.com';

-- If you want to reset all corrupted passwords to 'TempPass123!'
-- Uncomment the following line:
-- UPDATE Users SET PasswordHash = '$2a$11$rQOHNGjgfuVPfefL1cHmrOzXpQm1ZdGa6Q8SU8K5YzQ2XqVHl8sGi' WHERE PasswordHash NOT LIKE '$2_$%';

-- Verify the fix
SELECT 
    Id, 
    UserName, 
    Email, 
    PasswordHash,
    CASE 
        WHEN PasswordHash NOT LIKE '$2_$%' THEN 'CORRUPTED'
        ELSE 'VALID'
    END AS HashStatus
FROM Users 
WHERE Email = 'demo_admin@example.com';
