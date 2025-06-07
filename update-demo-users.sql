-- Update demo users
USE asmDB;

-- Update the demo_admin password if it exists
UPDATE Users 
SET PasswordHash = '$2a$11$lOeGOIPa9RN3v8bhCudRqe8ec/dBzVCdPELn9mTu6EEt3.Ki3pZ/y'
WHERE Email = 'demo_admin@example.com';

-- Create demo_user if it doesn't exist
SET @user_exists = (SELECT COUNT(*) FROM Users WHERE Email = 'demo_user@example.com');

-- Only insert if it doesn't exist
INSERT INTO Users (
    Id, UserName, NormalizedUserName, Email, NormalizedEmail, 
    FirstName, LastName, PasswordHash, SecurityStamp, ConcurrencyStamp, 
    CreatedAt, UpdatedAt, PhoneNumberConfirmed, IsAdmin, IsSuperAdmin, 
    IsEditor, IsModerator, IsStandardUser, IsBannedByAdmin, IsBlocked, 
    IsVerified, IsPending, IsGuest, IsUser, IsActive, IsDeleted, IsLockedOut, 
    LockoutEnabled, PhoneNumber, EmailConfirmed, TwoFactorEnabled, CreatedBy,
    IsLoggedIn, AccessFailedCount, FailedLoginAttempts
)
SELECT
    UUID(),
    'demo_standard',
    'DEMO_STANDARD',
    'demo_user@example.com',
    'DEMO_USER@EXAMPLE.COM',
    'Demo',
    'User',
    -- BCrypt hash for 'Demo+123456/'
    '$2a$11$lOeGOIPa9RN3v8bhCudRqe8ec/dBzVCdPELn9mTu6EEt3.Ki3pZ/y',
    UUID(),
    UUID(),
    NOW(),
    NOW(),
    0, -- PhoneNumberConfirmed
    0, -- IsAdmin
    0, -- IsSuperAdmin
    0, -- IsEditor 
    0, -- IsModerator
    1, -- IsStandardUser
    0, -- IsBannedByAdmin
    0, -- IsBlocked
    1, -- IsVerified
    0, -- IsPending
    0, -- IsGuest
    1, -- IsUser
    1, -- IsActive
    0, -- IsDeleted
    0, -- IsLockedOut
    0, -- LockoutEnabled
    '', -- PhoneNumber
    1, -- EmailConfirmed
    0, -- TwoFactorEnabled
    UUID(), -- CreatedBy
    0, -- IsLoggedIn
    0, -- AccessFailedCount
    0  -- FailedLoginAttempts
FROM dual
WHERE @user_exists = 0;
