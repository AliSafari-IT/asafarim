# Improve User Repository Tests and Fix Required Properties

Date: 2025-01-23

### Summary
This commit enhances the test coverage for the `UserRepository` class and addresses required properties in the `User` entity to ensure all necessary fields are populated during tests. The changes include:

### Changes Made

1. **UserRepository Tests**: 
   - Added tests for all methods in the `UserRepository` class, including:
     - `GetUserByEmailAsync`
     - `GetUserByIdAsync`
     - `GetAllUsersAsync`
     - `AddUserAsync`
     - `UpdateUserAsync`
     - `DeleteUserAsync`
     - `GetUserByUserNameAsync`
     - `GetUserByPhoneNumberAsync`
   
   - Each test checks for both successful scenarios and edge cases where users do not exist.

   ```csharp
   [TestMethod]
   public async Task GetUserByEmailAsync_ShouldReturnUser_WhenUserExists()
   {
       // Arrange
       var user = new User { Email = "test@example.com", ConcurrencyStamp = Guid.NewGuid().ToString(), SecurityStamp = Guid.NewGuid().ToString() };
       await _userRepository.AddUserAsync(user);

       // Act
       var result = await _userRepository.GetUserByEmailAsync("test@example.com");

       // Assert
       Assert.IsNotNull(result);
       Assert.AreEqual(user.Email, result.Email);
   }
   ```

2. **Required Properties**: 
   - Updated the `User` entity to ensure that `ConcurrencyStamp` and `SecurityStamp` are included when creating new users in the tests. This resolves issues related to missing required properties during database operations.

   ```csharp
   var user = new User
   {
       Email = "test@example.com",
       ConcurrencyStamp = Guid.NewGuid().ToString(),
       SecurityStamp = Guid.NewGuid().ToString(),
   };
   ```

### Conclusion
These changes improve the reliability of the `UserRepository` tests and ensure that all required fields are populated, preventing runtime errors related to missing properties.
