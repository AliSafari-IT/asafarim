# Refactor: Restructure User Preferences System

Date: 2024-02-04

## Description of Changes

### 1. Removed Legacy Preference System
- Removed old `UserPreference` and `Preference` entities
- Cleaned up related repositories and services
```csharp
// Removed from AppDbContext.cs
public DbSet<Preference> Preferences { get; set; }
public DbSet<UserPreference> UserPreferences { get; set; }
```

### 2. Introduced New Preference Structure
- Created separate user preference entities for better modularity:
  - UserAccessibilityPreference
  - UserGeographicalPreference
  - UserLanguagePreference
  - UserMiscellaneousPreference
  - UserNotificationPreference
  - UserPrivacyPreference
  - UserThemePreference

```csharp
// Example of new preference entity structure
public class UserAccessibilityPreference
{
    public Guid UserId { get; set; }
    public Guid AccessibilityPreferenceId { get; set; }
    public User? User { get; set; }
    public AccessibilityPreference? AccessibilityPreference { get; set; }
}
```

### 3. Updated Database Configuration
- Added composite keys for new preference entities
```csharp
modelBuilder.Entity<UserAccessibilityPreference>()
    .HasKey(ap => new { ap.UserId, ap.AccessibilityPreferenceId });
// Similar configuration for other preference entities
```

### 4. Updated Mapping Profiles
- Removed old preference mappings
- Added new direct mappings for each preference type
```csharp
CreateMap<GeographicalPreference, GeographicalPreferenceDto>();
CreateMap<NotificationPreference, NotificationPreferenceDto>();
CreateMap<LanguagePreference, LanguagePreferenceDto>();
// ... other preference mappings
```

## Impact
1. **Database Schema**:
   - Removed tables: `Preferences`, `UserPreferences`
   - Added new tables for each preference type
   - All existing preference data will need to be migrated

2. **API Endpoints**:
   - Updated preference-related endpoints to work with new structure
   - Each preference type now has its own dedicated endpoints

3. **User Interface**:
   - User preference forms will need to be updated to match new data structure
   - Preference management UI will need to be modified

## Files Affected
1. Domain Layer:
   - `User.cs`
   - New preference entity files
   - Removed `UserPreference.cs`

2. Infrastructure Layer:
   - `AppDbContext.cs`
   - Removed preference repositories
   - Updated database configuration

3. Application Layer:
   - Updated DTOs
   - Modified mapping profiles
   - Updated command models

## Testing
1. **Required Tests**:
   - Unit tests for new preference entities
   - Integration tests for preference management
   - API endpoint tests for each preference type
   - Migration tests for existing preference data

2. **Manual Testing**:
   - Verify preference creation/update/deletion
   - Test user preference synchronization
   - Validate preference data persistence
