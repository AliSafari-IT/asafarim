using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Application.Services;
using ASafariM.Application.Utils;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace ASafariM.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;
        private readonly JwtTokenService _jwtTokenService;
        private readonly ASafariM.Application.Interfaces.IAuthorizationService _authorizationService;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;

        public UserService(
            IUserRepository userRepository,
            IMapper mapper,
            AppDbContext context,
            ASafariM.Application.Interfaces.IAuthorizationService authorizationService,
            IConfiguration configuration,
            IEmailService emailService,
            JwtTokenService jwtTokenService
        )
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _dbContext = context;
            _authorizationService = authorizationService;
            _configuration = configuration;
            _emailService = emailService;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<bool> RegisterUserAsync(RegisterUserCommand command)
        {
            try
            {
                Log.Information(
                    "Attempting to register new user with email: {Email}",
                    command.Email
                );
                // Check if user already exists
                var existingUser = await _userRepository.GetUserByEmailAsync(command.Email);
                if (existingUser != null)
                {
                    Log.Warning(
                        "Registration failed - Email already in use: {Email}",
                        command.Email
                    );
                    throw new InvalidOperationException("Email is already in use.");
                }

                // Create and save the new user
                var hashedPassword = PasswordHasher.HashPassword(command.Password);
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    UserName = command.UserName,
                    Email = command.Email,
                    NormalizedEmail = command.Email.ToUpperInvariant(),
                    NormalizedUserName = command.UserName?.ToUpperInvariant(),
                    Biography = command.Biography,
                    ProfilePicture = command.ProfilePicture,
                    IsAdmin = command.IsAdmin,
                    DateOfBirth = command.DateOfBirth,
                    IsActive = true,
                    PasswordHash = hashedPassword,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    LastLogin = DateTime.UtcNow,
                };

                await _userRepository.AddUserAsync(user);
                Log.Information("Successfully registered new user with ID: {UserId}", user.Id);
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while registering user with email: {Email}",
                    command.Email
                );
                throw;
            }
        }

        public async Task<bool> LoginUserAsync(LoginUserCommand command)
        {
            try
            {
                Log.Information("Attempting to login user with email: {Email}", command.Email);
                // Verify user credentials
                var user = await _userRepository.GetUserByEmailAsync(command.Email);
                if (
                    user == null
                    || !PasswordHasher.VerifyPassword(command.Password, user.PasswordHash)
                )
                {
                    Log.Information("Login failed for email: {Email}", command.Email);
                    return false;
                }
                Log.Information("Login successful for email: {Email}", command.Email);
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while logging in user with email: {Email}",
                    command.Email
                );
                throw;
            }
        }

        public async Task<UserDto?> GetUserByIdAsync(Guid userId)
        {
            try
            {
                Log.Information("Fetching user by ID: {UserId}", userId);
                // Fetch user by ID
                var user = await _userRepository.GetUserByIdAsync(userId);
                // Map to UserDto
                if (user == null)
                {
                    Log.Warning("User not found with ID: {UserId}", userId);
                    return null; // or handle accordingly
                }

                Log.Information(
                    "GetUserByIdAsync: User LastLogin value: {LastLogin}",
                    user.LastLogin
                );
                // Map the entity to UserDto through UserInfoDto
                var userInfoDto = _mapper.Map<UserInfoDto>(user);
                Log.Information(
                    "GetUserByIdAsync: UserInfoDto LastLogin value: {LastLogin}",
                    userInfoDto.LastLogin
                );
                var userDto = _mapper.Map<UserDto>(userInfoDto);
                Log.Information(
                    "GetUserByIdAsync: UserDto LastLogin value: {LastLogin}",
                    userDto.LastLogin
                );
                return userDto;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching user by ID: {UserId}", userId);
                throw;
            }
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync(bool includeSoftDeleted = false)
        {
            try
            {
                Log.Information(
                    "Fetching all users. Including soft deleted: {IncludeSoftDeleted}",
                    includeSoftDeleted
                );
                var users = await _userRepository.GetAllUsersAsync(includeSoftDeleted);
                var userDtos = users.Select(u => new UserDto
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    UserName = u.UserName,
                    Email = u.Email,
                    IsAdmin = u.IsAdmin,
                    IsDeleted = u.IsDeleted,
                    DeletedAt = u.DeletedAt,
                    CreatedAt = u.CreatedAt,
                    UpdatedAt = u.UpdatedAt,
                    ProfilePicture = u.ProfilePicture,
                    Biography = u.Biography,
                    IsActive = u.IsActive,
                    DateOfBirth = u.DateOfBirth,
                    LastLogin = u.LastLogin,
                });

                var result = userDtos.ToList().AsEnumerable();
                Log.Information("Successfully fetched {Count} users", result.Count());
                return result;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching all users");
                throw;
            }
        }

        public async Task<User> CreateUserAsync(CreateUserCommand command)
        {
            try
            {
                Log.Information("Creating new user with email: {Email}", command.Email);

                // Check if email or username already exists
                if (await _userRepository.UserExistsByEmailAsync(command.Email))
                {
                    Log.Warning("Email {Email} is already taken", command.Email);
                    throw new InvalidOperationException($"Email {command.Email} is already taken.");
                }

                if (await _userRepository.UserExistsByUserNameAsync(command.UserName))
                {
                    Log.Warning("Username {UserName} is already taken", command.UserName);
                    throw new InvalidOperationException(
                        $"Username {command.UserName} is already taken."
                    );
                }

                // Normalize Email and Username
                var normalizedEmail = command.Email.ToUpperInvariant();
                var normalizedUserName = command.UserName?.ToUpperInvariant();

                // Generate SecurityStamp and ConcurrencyStamp
                var securityStamp = Guid.NewGuid().ToString();
                var concurrencyStamp = Guid.NewGuid().ToString();

                // Hash the password using secure PBKDF2 with salt
                var passwordHash = PasswordHasher.HashPassword(command.Password);

                // Create the User entity
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    Email = command.Email,
                    NormalizedEmail = normalizedEmail,
                    UserName = command.UserName,
                    NormalizedUserName = normalizedUserName,
                    PasswordHash = passwordHash,
                    SecurityStamp = securityStamp,
                    ConcurrencyStamp = concurrencyStamp,
                    CreatedAt = command.CreatedAt ?? DateTime.UtcNow,
                    UpdatedAt = command.UpdatedAt ?? DateTime.UtcNow,
                    DateOfBirth = command.DateOfBirth,
                    IsActive = command.IsActive,
                    IsStandardUser = true,
                    LastLogin = command.LastLogin,
                    Biography = command.Biography ?? string.Empty,
                    IsAdmin = command.IsAdmin,
                    IsUser = true,
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    Name = $"{command.FirstName} {command.LastName}",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    CreatedBy =
                        Guid.Empty // System created
                    ,
                    UpdatedBy =
                        Guid.Empty // System updated
                    ,
                    DeletedBy = null, // Not deleted
                    DeletedAt = null, // Not deleted
                };

                // Save to the database
                await _userRepository.AddUserAsync(user);
                Log.Information("Successfully created user with ID: {UserId}", user.Id);
                return user;
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while creating user with email: {Email}",
                    command.Email
                );
                throw;
            }
        }

        public async Task<UserDto?> UpdateUserAsync(UpdateUserCommand command)
        {
            try
            {
                Log.Information("Updating user with ID: {UserId}", command.Id);
                // Update the user by ID
                var user = await _userRepository.GetUserByIdAsync(command.Id);
                if (user == null)
                {
                    Log.Warning("User not found for update with ID: {UserId}", command.Id);
                    throw new InvalidOperationException("User not found.");
                }
                user.Email = command.Email ?? user.Email;
                user.UserName = command.UserName ?? user.UserName;
                user.FirstName = command.FirstName ?? user.FirstName;
                user.LastName = command.LastName ?? user.LastName;
                user.Biography = command.Biography ?? user.Biography;
                user.ProfilePicture = command.ProfilePicture ?? user.ProfilePicture;
                user.DateOfBirth = command.DateOfBirth ?? user.DateOfBirth;
                user.IsActive = command.IsActive ?? user.IsActive;
                user.UpdatedAt = DateTime.UtcNow;

                await _userRepository.UpdateUserAsync(user);
                Log.Information("Successfully updated user with ID: {UserId}", command.Id);
                return _mapper.Map<User, UserDto>(user);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while updating user with ID: {UserId}", command.Id);
                throw;
            }
        }

        public async Task<UserDto?> UpdateUserByAdminAsync(UpdateUserByAdminCommand command)
        {
            try
            {
                Log.Information("Admin updating user with ID: {UserId}", command.Id);
                var user = await _userRepository.GetUserByIdAsync(command.Id);
                if (user == null)
                {
                    Log.Warning("User not found for admin update with ID: {UserId}", command.Id);
                    throw new InvalidOperationException("User not found.");
                }
                user.Email = command.Email ?? user.Email;
                user.UserName = command.UserName ?? user.UserName;
                user.FirstName = command.FirstName ?? user.FirstName;
                user.LastName = command.LastName ?? user.LastName;
                user.Biography = command.Biography ?? user.Biography;
                user.ProfilePicture = command.ProfilePicture ?? user.ProfilePicture;
                user.DateOfBirth = command.DateOfBirth ?? user.DateOfBirth;
                user.IsActive = command.IsActive ?? user.IsActive;
                user.IsAdmin = command.IsAdmin ?? user.IsAdmin;
                user.UpdatedAt = DateTime.UtcNow;

                await _userRepository.UpdateUserAsync(user);
                Log.Information("Successfully updated user by admin with ID: {UserId}", command.Id);
                return _mapper.Map<User, UserDto>(user);
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while admin updating user with ID: {UserId}",
                    command.Id
                );
                throw;
            }
        }

        public async Task<bool> DeleteUserAsync(Guid id, string password)
        {
            try
            {
                Log.Information("Deleting user with ID: {UserId}", id);
                var user = await _userRepository.GetUserByIdAsync(id);
                if (user == null)
                {
                    Log.Warning("User not found for deletion with ID: {UserId}", id);
                    return false;
                }

                // Verify password
                var passwordVerificationResult = PasswordHasher.VerifyPassword(
                    password,
                    user.PasswordHash
                );
                if (!passwordVerificationResult)
                {
                    Log.Warning(
                        "Invalid password provided for user deletion with ID: {UserId}",
                        id
                    );
                    return false;
                }

                try
                {
                    await _userRepository.DeleteUserAsync(id);
                    Log.Information("User deleted successfully with ID: {UserId}", id);
                    return true;
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Failed to delete user with ID: {UserId}", id);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while deleting user with ID: {UserId}", id);
                throw;
            }
        }

        public async Task<bool> DeleteUserByAdminAsync(Guid id, bool isPermanent)
        {
            try
            {
                Log.Information(
                    "Admin {action} user with ID: {UserId}",
                    isPermanent ? "deleting" : "soft deleting",
                    id
                );
                var user = await _userRepository.GetUserByIdAsync(id);
                if (user == null)
                {
                    Log.Warning("User not found for admin deletion with ID: {UserId}", id);
                    return false;
                }

                try
                {
                    // Use the execution strategy for the delete operation
                    await _dbContext
                        .Database.CreateExecutionStrategy()
                        .ExecuteAsync(async () =>
                        {
                            if (isPermanent)
                            {
                                await _userRepository.DeleteUserAsync(id);
                            }
                            else
                            {
                                user.IsDeleted = true;
                                user.DeletedAt = DateTime.UtcNow;
                                await UpdateUserByAdminAsync(
                                    new UpdateUserByAdminCommand
                                    {
                                        Id = user.Id,
                                        Email = user.Email,
                                        UserName = user.UserName,
                                        Biography = user.Biography,
                                        ProfilePicture = user.ProfilePicture,
                                        DateOfBirth = user.DateOfBirth,
                                        IsActive = user.IsActive,
                                        IsAdmin = user.IsAdmin,
                                    }
                                );
                            }
                        });

                    Log.Information(
                        "User {action} successfully by admin with ID: {UserId}",
                        isPermanent ? "deleted" : "soft deleted",
                        id
                    );
                    return true;
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Error occurred while admin deleting user with ID: {UserId}", id);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while deleting user with ID: {UserId}", id);
                throw;
            }
        }

        public async Task<bool> ChangePasswordAsync(ChangePasswordCommand command)
        {
            try
            {
                Log.Information(
                    "Attempting to change password for user with ID: {UserId}",
                    command.Id
                );
                var user = await _userRepository.GetUserByIdAsync(command.Id);

                if (user == null)
                {
                    Log.Warning("User not found for password change with ID: {UserId}", command.Id);
                    throw new InvalidOperationException("User not found.");
                }

                user.PasswordHash = PasswordHasher.HashPassword(command.NewPassword);
                user.UpdatedAt = DateTime.UtcNow;

                await _userRepository.UpdateUserAsync(user);
                Log.Information(
                    "Successfully changed password for user with ID: {UserId}",
                    command.Id
                );
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while changing password for user with ID: {UserId}",
                    command.Id
                );
                throw;
            }
        }

        public async Task UpdateProfileAsync(UpdateProfileCommand command)
        {
            try
            {
                Log.Information("Updating profile for user with ID: {UserId}", command.UserId);
                if (command == null)
                {
                    Log.Error("UpdateProfileCommand is null");
                    throw new ArgumentNullException(nameof(command));
                }

                if (_userRepository == null)
                {
                    Log.Error("User repository is null");
                    throw new InvalidOperationException("User repository is null");
                }

                var user = await _userRepository.GetUserByIdAsync(command.UserId);
                if (user == null)
                {
                    Log.Warning(
                        "User not found for profile update with ID: {UserId}",
                        command.UserId
                    );
                    throw new InvalidOperationException("User not found");
                }

                // Update user properties only if they are provided in the command
                if (!string.IsNullOrEmpty(command.FirstName))
                    user.FirstName = command.FirstName;
                
                if (!string.IsNullOrEmpty(command.LastName))
                    user.LastName = command.LastName;
                
                if (!string.IsNullOrEmpty(command.Email))
                    user.Email = command.Email;
                
                if (!string.IsNullOrEmpty(command.UserName))
                    user.UserName = command.UserName;
                
                // Only update PhoneNumber if it's provided, otherwise keep the existing value
                if (!string.IsNullOrEmpty(command.PhoneNumber))
                    user.PhoneNumber = command.PhoneNumber;
                
                // Update optional fields if provided
                if (!string.IsNullOrEmpty(command.ProfilePicture))
                    user.ProfilePicture = command.ProfilePicture;
                
                if (!string.IsNullOrEmpty(command.Biography))
                    user.Biography = command.Biography;
                
                if (command.BirthDate.HasValue)
                    user.DateOfBirth = command.BirthDate.Value;

                user.UpdatedAt = DateTime.UtcNow;
                user.UpdatedBy = command.UserId;

                await _userRepository.UpdateUserAsync(user);
                Log.Information(
                    "Successfully updated profile for user with ID: {UserId}",
                    command.UserId
                );
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while updating profile for user with ID: {UserId}",
                    command.UserId
                );
                throw;
            }
        }

        public async Task<IsTakenDto?> IsUsernameNotTakenAsync(string username)
        {
            try
            {
                Log.Information("Checking if username is taken: {Username}", username);
                var normalizedUsername = username.ToUpperInvariant();
                var exists = await _dbContext.Users.AnyAsync(u =>
                    u.NormalizedUserName == normalizedUsername && u.IsDeleted == false
                );

                Log.Information(
                    "Username {Username} is {Status}",
                    username,
                    exists ? "taken" : "available"
                );
                return new IsTakenDto { IsTaken = exists };
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while checking username availability: {Username}",
                    username
                );
                throw;
            }
        }

        public async Task<IsTakenDto?> IsEmailNotTakenAsync(string email)
        {
            try
            {
                Log.Information("Checking if email is taken: {Email}", email);
                var normalizedEmail = email.ToUpperInvariant();
                var exists = await _dbContext.Users.AnyAsync(u =>
                    u.NormalizedEmail == normalizedEmail && u.IsDeleted == false
                );

                Log.Information("Email {Email} is {Status}", email, exists ? "taken" : "available");
                return new IsTakenDto { IsTaken = exists };
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while checking email availability: {Email}", email);
                throw;
            }
        }

        public async Task<UserDto?> CreateUserByAdminAsync(CreateUserByAdminCommand command)
        {
            try
            {
                Log.Information("Admin creating new user with email: {Email}", command.Email);
                // Normalize Email and Username
                var normalizedEmail = command.Email.ToUpperInvariant();
                var normalizedUserName = command.UserName?.ToUpperInvariant();

                // Generate SecurityStamp and ConcurrencyStamp
                var securityStamp = Guid.NewGuid().ToString();
                var concurrencyStamp = Guid.NewGuid().ToString();

                // Hash the password using secure PBKDF2 with salt
                var passwordHash = PasswordHasher.HashPassword(command.Password);

                // Create the User entity
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    Email = command.Email,
                    NormalizedEmail = normalizedEmail,
                    UserName = command.UserName,
                    NormalizedUserName = normalizedUserName,
                    PasswordHash = passwordHash,
                    IsAdmin = command.IsAdmin,
                    SecurityStamp = securityStamp,
                    ConcurrencyStamp = concurrencyStamp,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    DateOfBirth = command.DateOfBirth,
                    IsActive = true,
                    IsStandardUser = true,
                    LastLogin = DateTime.UtcNow,
                    Biography = "",
                    IsUser = true,
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    Name = $"{command.FirstName} {command.LastName}",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    CreatedBy =
                        Guid.Empty // System created
                    ,
                };

                await _userRepository.AddUserAsync(user);
                Log.Information("Successfully created user by admin with ID: {UserId}", user.Id);
                return _mapper.Map<User, UserDto>(user);
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while admin creating user with email: {Email}",
                    command.Email
                );
                throw;
            }
        }

        public async Task<IEnumerable<UserDto>> SearchUsersAsync(string? username, string? email)
        {
            try
            {
                Log.Information(
                    "Searching users with username: {Username}, email: {Email}",
                    username,
                    email
                );
                var users = await _userRepository.GetUsersByUserNameOrEmailAsync(username, email);
                Log.Information(
                    "Found {Count} users matching search criteria",
                    users?.Count() ?? 0
                );
                return _mapper.Map<IEnumerable<User>, IEnumerable<UserDto>>(users);
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while searching users with username: {Username}, email: {Email}",
                    username,
                    email
                );
                throw;
            }
        }

        public async Task<IEnumerable<UserRoleDto>> GetRolesByUserId(string userId)
        {
            try
            {
                Log.Information("Fetching roles for user with ID: {UserId}", userId);
                var userRoles = await _userRepository.GetRolesByUserIdAsync(Guid.Parse(userId));
                if (userRoles is null || !userRoles.Any())
                {
                    return Enumerable.Empty<UserRoleDto>(); // or handle as appropriate
                }
                Log.Information(
                    "Found {Count} roles for user with ID: {UserId}",
                    userRoles?.Count() ?? 0,
                    userId
                );
                return _mapper.Map<IEnumerable<UserRole>, IEnumerable<UserRoleDto>>(userRoles);
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while fetching roles for user with ID: {UserId}",
                    userId
                );
                throw;
            }
        }

        public async Task<bool> ForgotPasswordAsync(ForgotPasswordCommand command)
        {
            var user = await _userRepository.GetUserByEmailAsync(command.Email);
            if (user == null)
            {
                return false;
            }
            var token = _jwtTokenService.GeneratePasswordResetToken(user);
            user.ForgotPasswordToken = token;
            user.ForgotPasswordTokenExpiration = DateTime.UtcNow.AddDays(7);
            await _userRepository.UpdateUserAsync(user);
            return true;
        }

        public async Task<bool> ResetPasswordAsync(ResetPasswordCommand command)
        {
            var user = await _userRepository.GetUserByEmailAsync(command.Email);
            if (user == null)
            {
                return false;
            }

            // Validate the token
            if (
                string.IsNullOrEmpty(user.ForgotPasswordToken)
                || user.ForgotPasswordToken != command.Token
                || !user.ForgotPasswordTokenExpiration.HasValue
                || user.ForgotPasswordTokenExpiration.Value < DateTime.UtcNow
            )
            {
                // Token is invalid or expired
                return false;
            }

            user.PasswordHash = PasswordHasher.HashPassword(command.NewPassword);
            user.UpdatedAt = DateTime.UtcNow;
            user.ForgotPasswordToken = null;
            user.ForgotPasswordTokenExpiration = null;
            await _userRepository.UpdateUserAsync(user);
            return true;
        }

        public async Task<bool> IsUserAdminAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return user.IsAdmin;
        }

        public async Task<bool> IsUserSuperAdminAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return user.IsSuperAdmin;
        }

        public async Task<bool> IsUserEditorAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return user.IsEditor;
        }

        public async Task<bool> IsUserModeratorAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return user.IsModerator;
        }

        public async Task<bool> IsUserStandardUserAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return !user.IsAdmin && !user.IsSuperAdmin && !user.IsEditor && !user.IsModerator;
        }

        public async Task<bool> IsUserBannedByAdminAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return user.IsBannedByAdmin;
        }

        public async Task<bool> IsUserBlockedAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return user.IsBlocked;
        }

        public async Task<bool> IsUserVerifiedAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return user.IsVerified;
        }

        public async Task<bool> IsPendingAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return user.IsPending;
        }

        public async Task<bool> IsGuestAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return user.IsGuest;
        }

        public async Task<bool> IsUserLockedOutAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return user.IsLockedOut;
        }

        public async Task<bool> IsUserActiveAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            if (user?.IsActive != true)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> RequestAccountReactivationAsync(
            RequestAccountReactivationCommand command
        )
        {
            var user = await _userRepository.GetUserByEmailAsync(command.Email);
            if (user == null || !user.IsDeleted)
            {
                return false;
            }

            // Send reactivation email
            _emailService.SendReactivationEmail(user.Email, command.ReactivationReason);

            // Create reactivation request record
            user.ReactivationRequestedAt = DateTime.UtcNow;
            user.ReactivationReason = command.ReactivationReason;

            await _userRepository.UpdateUserAsync(user);
            await _userRepository.SaveChangesAsync();
            Log.Information("Reactivation request sent to user with email: {Email}", user.Email);

            return true;
        }

        public async Task RevokeUserTokenAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return;
            }
            user.Token = null; // Clear JWT access token
            user.RefreshToken = null; // Clear Refresh Token
            user.RefreshTokenExpiration = null;
            await _userRepository.UpdateUserAsync(user);
            await _userRepository.SaveChangesAsync();
        }

        public static string GenerateRefreshToken()
        {
            var randomBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes);
        }

        public async Task RevokeUserRefreshTokenAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return;
            }
            user.RefreshToken = null;
            await _userRepository.UpdateUserAsync(user);
            await _userRepository.SaveChangesAsync();
        }

        public async Task<UserDto?> GetByIdAsync(Guid userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                return null;
            }
            return _mapper.Map<UserDto>(user);
        }
    }
}
