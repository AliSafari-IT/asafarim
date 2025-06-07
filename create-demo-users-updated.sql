-- Create demo users
USE asmDB;

-- Check if demo_admin exists
SET @admin_exists = (SELECT COUNT(*) FROM Users WHERE Email = 'demo_admin@example.com');
SET @user_exists = (SELECT COUNT(*) FROM Users WHERE Email = 'demo_user@example.com');

-- Only insert if they don't exist
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
    'demo_admin',
    'DEMO_ADMIN',
    'demo_admin@example.com',
    'DEMO_ADMIN@EXAMPLE.COM',
    'Demo',
    'Admin',
    -- BCrypt hash for 'Demo+123456/'
    '$2a$11$lOeGOIPa9RN3v8bhCudRqe8ec/dBzVCdPELn9mTu6EEt3.Ki3pZ/y',
    UUID(),
    UUID(),
    NOW(),
    NOW(),
    0, -- PhoneNumberConfirmed
    1, -- IsAdmin
    0, -- IsSuperAdmin
    0, -- IsEditor 
    0, -- IsModerator
    0, -- IsStandardUser
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
WHERE @admin_exists = 0;

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
    'demo_user',
    'DEMO_USER',
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
