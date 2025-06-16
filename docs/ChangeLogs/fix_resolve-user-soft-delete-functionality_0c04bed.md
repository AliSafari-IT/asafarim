# Fix: Resolve User Soft Delete Functionality Issues

Date: 2025-02-15

## Description of Changes

### 1. Fixed API Request Body Format
Updated the delete user API call to properly send the request body:
```typescript
// Before
const response = await api.delete(deleteUrl, {
  params: {
    isAdmin: true,
    isPermanent
  }
});

// After
const response = await api.delete(deleteUrl, {
  data: {
    isAdmin: true,
    isPermanent
  }
});
```

### 2. Improved Delete Dialog UI and Behavior
Enhanced the delete confirmation dialog with better UX and proper state management:
```typescript
const handleSoftDelete = async () => {
  if (!selectedUserId) return;

  try {
    await deleteUserByAdmin(selectedUserId, false);
    setUsers(prevUsers => prevUsers.map(user => 
      user.id === selectedUserId ? { 
        ...user, 
        isDeleted: true, 
        deletedAt: new Date().toISOString() 
      } : user
    ));
  } catch (err) {
    setError('Failed to soft delete the user.');
    console.error(err);
  } finally {
    setDeleteDialogOpen(false);
    setSelectedUserId(null);
  }
};
```

### 3. Fixed User Seeding Date Generation
Updated the date generation logic to ensure valid dates for seeded users:
```csharp
// Before
DateOfBirth = new DateTime(1975, 7, 1 + i)

// After
DateOfBirth = new DateTime(1975 + (i / 12), 1 + (i % 12), 1 + (i % 28))
```

### 4. Enhanced Delete Dialog UI
Improved the delete dialog with better accessibility and user feedback:
```tsx
<button 
  className="w-full group p-4 rounded-md border border-[var(--border-default)] hover:border-[var(--border-warning)] hover:bg-[var(--background-warning-subtle)] transition-colors"
  onClick={handleSoftDelete}
>
  <div className="flex items-center gap-2 mb-2">
    <div className="w-2 h-2 rounded-full bg-[var(--text-warning)]"></div>
    <h3 className="font-medium text-[var(--text-default)]">Soft Delete</h3>
  </div>
  <p className="text-sm text-[var(--text-muted)] pl-4">
    Marks the user as deleted while preserving their data. They won't be able to log in,
    but their data can be restored later if needed.
  </p>
</button>
```

## Impact
- User deletion functionality now works correctly for both soft and permanent deletes
- Improved user experience with better feedback and UI interactions
- Fixed seeded user data generation for testing
- Enhanced visual indication of soft-deleted users in the list

## Files Affected
1. `ASafariM.Clients/asafarim-ui/src/api/userService.ts`
2. `ASafariM.Clients/asafarim-ui/src/pages/User/UsersList.tsx`
3. `ASafariM.Infrastructure/Persistence/AppDbContext.cs`
4. `ASafariM.Infrastructure/Services/UserService.cs`
5. `ASafariM.Infrastructure/Migrations/*_UserSeeded.cs`

## Testing
1. **Soft Delete**
   - Click the delete button for a user
   - Select "Soft Delete"
   - Verify the user remains in the list but is visually marked as deleted
   - Verify the user data is preserved in the database

2. **Permanent Delete**
   - Click the delete button for a user
   - Select "Permanent Delete"
   - Verify the user is removed from the list
   - Verify the user is removed from the database

3. **Dialog Behavior**
   - Verify the dialog closes after successful operations
   - Verify proper error handling and user feedback
   - Test cancel button functionality

4. **UI/UX**
   - Verify soft-deleted users are visually distinct
   - Check hover states and transitions
   - Verify dialog accessibility
