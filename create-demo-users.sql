-- Create demo users
USE asmDB;

-- Check if demo_admin exists
SET @admin_exists = (SELECT COUNT(*) FROM Users WHERE Email = 'demo_admin@example.com');
SET @user_exists = (SELECT COUNT(*) FROM Users WHERE Email = 'demo_user@example.com');

-- Only insert if they don't exist
INSERT INTO Users (Id, UserName, NormalizedUserName, Email, NormalizedEmail, FirstName, LastName, PasswordHash, SecurityStamp, ConcurrencyStamp, CreatedAt, UpdatedAt)
SELECT
    UUID(),
    'demo_admin',
    'DEMO_ADMIN',
    'demo_admin@example.com',
    'DEMO_ADMIN@EXAMPLE.COM',
    'Demo',
    'Admin',
    -- BCrypt hash for 'Demo+123456/'
    'a1/dBzVCdPELn9mTu6EEt3.Ki3pZ/y',
    UUID(),
    UUID(),
    NOW(),
    NOW()
FROM dual
WHERE @admin_exists = 0;

INSERT INTO Users (Id, UserName, NormalizedUserName, Email, NormalizedEmail, FirstName, LastName, PasswordHash, SecurityStamp, ConcurrencyStamp, CreatedAt, UpdatedAt)
SELECT
    UUID(),
    'demo_user',
    'DEMO_USER',
    'demo_user@example.com',
    'DEMO_USER@EXAMPLE.COM',
    'Demo',
    'User',
    -- BCrypt hash for 'Demo+123456/'
    'a1/dBzVCdPELn9mTu6EEt3.Ki3pZ/y',
    UUID(),
    UUID(),
    NOW(),
    NOW()
FROM dual
WHERE @user_exists = 0;
