# Fix: Restore functionality for adding roles to users

Date 2025-01-26

## Description of Changes
- Restored the functionality to add roles to users in the `UserRolesController`.
- Updated `UserRoleDto` to ensure it contains the necessary properties for role management.

### Important Code Snippets:

#### UserRolesController.cs
```csharp
public async Task<IActionResult> AssignRolesToUser(string userId, [FromBody] IEnumerable<Guid> roleIds) {
    // Logic to assign roles to the user
}
```

#### UserRoleDto.cs
```csharp
public class UserRoleDto
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
    public string? RoleName { get; set; } // Updated to nullable
}
```

## Impact
- Restored the role assignment functionality in the application.

## Files affected
- `ASafariM.Presentation/Controllers/UserRolesController.cs`
- `ASafariM.Application/DTOs/UserRoleDto.cs`

## Testing
- Integration tests were updated and executed to ensure that the role assignment functionality works as expected.
