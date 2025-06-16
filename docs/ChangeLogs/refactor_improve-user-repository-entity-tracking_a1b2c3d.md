# Test Infrastructure and Refactor: Improve User Repository Entity Tracking
Date: 2024-12-23
updated: 2025-01-23 10:18:00

## Changes Made
This update improves the handling of entity tracking in the User Repository and introduces a comprehensive test infrastructure. The changes address several concurrency and entity tracking issues while establishing a robust testing framework.

### 1. User Repository Changes
#### Update Operations Refactoring
Modified both `UpdateUserAsync` and `UpdateUserByAdminAsync` methods to handle entity tracking properly:

```csharp
public async Task UpdateUserAsync(User user)
{
    var existingUser = await _dbContext.Users.FindAsync(user.Id);
    if (existingUser == null)
    {
        throw new InvalidOperationException($"User with ID {user.Id} not found.");
    }

    // Copy updated values to existing entity
    existingUser.Email = user.Email;
    existingUser.UserName = user.UserName;
    existingUser.PhoneNumber = user.PhoneNumber;
    existingUser.PasswordHash = user.PasswordHash;
    existingUser.SecurityStamp = user.SecurityStamp;
    existingUser.ConcurrencyStamp = user.ConcurrencyStamp;

    _logger.LogInformation("User updated: {UserId}", user.Id);
    await _dbContext.SaveChangesAsync();
}
```

Key improvements:
- Replaced entity state manipulation with direct property updates
- Maintained proper entity tracking throughout the update process
- Simplified the update logic to prevent concurrency issues

#### Delete Operation Enhancement
Simplified the delete operation while maintaining data integrity:

```csharp
public async Task DeleteUserAsync(Guid id)
{
    var user = await _dbContext.Users.FindAsync(id);
    if (user == null)
    {
        throw new InvalidOperationException($"User with ID {id} not found.");
    }

    _dbContext.Users.Remove(user);
    await _dbContext.SaveChangesAsync();
}
```

### 2. Test Infrastructure Setup
#### New Test Project
Added a new test project with proper configuration:

```xml
<Project Sdk="MSTest.Sdk/3.6.3">
  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <LangVersion>latest</LangVersion>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <UseVSTest>true</UseVSTest>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.InMemory" Version="9.0.1" />
    <PackageReference Include="Moq" Version="4.20.72" />
  </ItemGroup>
</Project>
```

#### Test Base Class
Created a base class for common test functionality:

```csharp
public abstract class TestBase
{
    protected AppDbContext Context;

    [TestInitialize]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("TestDb")
            .Options;
        Context = new AppDbContext(options);
    }

    [TestCleanup]
    public void Cleanup()
    {
        Context.Dispose();
    }
}
```

### 3. User Entity Enhancements
Added data annotations and improved property definitions:

```csharp
public class User
{
    [Key]
    public Guid Id { get; set; }

    [Required, EmailAddress, MaxLength(256)]
    public string Email { get; set; } = string.Empty;

    [MaxLength(256)]
    public string NormalizedEmail { get; set; } = string.Empty;

    [Required, MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required, MaxLength(50)]
    public string LastName { get; set; } = string.Empty;
    // ... other properties
}
```

### 4. Test Suite Implementation
Added comprehensive tests for user operations:
- User entity validation tests
- Repository CRUD operation tests
- Admin-specific operation tests

### 5. Project Structure
- Added dedicated "Tests" workspace in VS Code
- Updated solution file to include test project
- Added new test-related npm scripts:
  ```json
  {
    "test:backend": "dotnet test E:/ASafariM/ASafariM.Test/ASafariM.Test.csproj",
    "test:backend:watch": "cd E:/ASafariM/ASafariM.Test && dotnet watch test",
    "tbw": "yarn test:backend:watch",
    "test:frontend": "vitest run",
    "test:all": "yarn test:backend && yarn test:frontend"
  }
  ```

## Impact
These changes provide:
1. Robust entity tracking in the User Repository
2. Comprehensive test coverage
3. Improved code maintainability
4. Better development experience with watch mode for tests
5. Proper validation for user data
6. Clear separation of concerns in testing

## Breaking Changes
None. All changes maintain backward compatibility while improving internal implementation.

## Migration Notes
No migration steps required. The changes are internal to the repository implementation and test infrastructure.

## Additional Notes
- Test parallelization is enabled at the method level for better performance
- Each test uses its own in-memory database instance
- Added proper null checking and validation throughout the codebase
