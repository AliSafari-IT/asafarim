# Refactor: Improve User Role Management Architecture

Date: 2025-01-26

## Description of Changes

### 1. Removed User.Roles Navigation Property
Removed the navigation property from the User entity for better separation of concerns:
```csharp
// Before
public class User
{
    public List<UserRole> Roles { get; set; } = new List<UserRole>();
}

// After
public class User
{
    // Navigation property removed
}
```

### 2. Updated Entity Configuration
Modified the AppDbContext configuration to handle the relationship without navigation property:
```csharp
modelBuilder.Entity<UserRole>(entity =>
{
    entity.HasKey(ur => new { ur.UserId, ur.RoleId });

    entity
        .HasOne(ur => ur.User)
        .WithMany()  // No navigation property
        .HasForeignKey(ur => ur.UserId)
        .OnDelete(DeleteBehavior.Cascade);
});
```

### 3. Dedicated Role Management Endpoints
Moved role management to a dedicated UserRolesController:
```csharp
[ApiController]
[Route("api/[controller]")]
public class UserRolesController : ControllerBase
{
    [HttpGet("{userId}/roles")]
    public async Task<ActionResult<UserRoleDto[]>> GetRolesByUserIdAsync(string userId)
    {
        var roles = await _userRepository.GetRolesByUserIdAsync(Guid.Parse(userId));
        return Ok(_mapper.Map<IEnumerable<UserRole>, IEnumerable<UserRoleDto>>(roles));
    }
}
```

### 4. Improved Role Management in Repository
Updated UserRepository to handle roles without navigation property:
```csharp
public async Task<IEnumerable<UserRole>> GetRolesByUserIdAsync(Guid userId)
{
    return await _dbContext
        .UserRoles.Where(ur => ur.UserId == userId)
        .Include(ur => ur.Role)
        .ToListAsync();
}
```

### 5. Enhanced Frontend Role Handling
Updated frontend services with better error handling:
```typescript
export const getRolesByUserId = async (userId: string): Promise<IUserRole[]> => {
  try {
    const response = await api.get(`${USER_ROLES_URL}/${userId}/roles`);
    console.log('Get roles response:', response.data);
    return response.data;
  } catch (error) {
    console.error(`Failed to fetch roles for user ${userId}:`, error);
    return [];
  }
};
```

## Impact
- User role management now follows a more maintainable architecture
- Improved separation of concerns between User and Role management
- Better error handling and logging throughout the role management flow
- Cleaner API endpoints with dedicated controller for role operations

## Files Affected
### Backend
- `ASafariM.Domain/Entities/User.cs`
- `ASafariM.Domain/Interfaces/IUserRepository.cs`
- `ASafariM.Infrastructure/Repositories/UserRepository.cs`
- `ASafariM.Infrastructure/Persistence/AppDbContext.cs`
- `ASafariM.Infrastructure/Services/UserService.cs`
- `ASafariM.Application/DTOs/UserDto.cs`
- `ASafariM.Application/Mappings/UserMappingProfile.cs`
- `ASafariM.Presentation/Controllers/UserRolesController.cs`
- `ASafariM.Presentation/Controllers/UsersController.cs`

### Frontend
- `ASafariM.Clients/asafarim-ui/src/api/userService.ts`
- `ASafariM.Clients/asafarim-ui/src/pages/User/EditUser.tsx`

## Testing
  <h5>1. Unit Tests</h5>

   - Test role assignment with valid and invalid role IDs
   - Test role removal
   - Test role retrieval for users

  <h5>2. Integration Tests</h5>

   - Test complete role management flow through API endpoints
   - Verify cascade deletion behavior
   - Test error scenarios (invalid roles, non-existent users)

  <h5>3. Frontend Tests</h5>
  
   - Test role selection in EditUser component
   - Verify role display in user list
   - Test error handling in role management UI
