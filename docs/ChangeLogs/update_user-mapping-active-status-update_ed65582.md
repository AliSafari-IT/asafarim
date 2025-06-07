# Added User Mapping, Fixed Active Status Handling, and Improved Update Functionality
date: 2025-01-22

### Mapping Configuration

  - Added mapping from `User` to `UserDto` in `UserMappingProfile` to resolve `AutoMapperMappingException`.
  - **Code Snippet**:
    ```csharp
    CreateMap<User, UserDto>()
        .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
        .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
        .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
        .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
        .ForMember(dest => dest.IsAdmin, opt => opt.MapFrom(src => src.IsAdmin))
        .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
        .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
        .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
        .ForMember(dest => dest.Bio, opt => opt.MapFrom(src => src.Bio))
        .ForMember(dest => dest.ProfilePicture, opt => opt.MapFrom(src => src.ProfilePicture))
        .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
        .ForMember(dest => dest.LastLogin, opt => opt.MapFrom(src => src.LastLogin))
        .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
        .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
        .ReverseMap();
    ```

### User Profile Component

  - Fixed handling of the user's active status in the `UserProfile` component.
  - **Code Snippet**:
    ```tsx
    useEffect(() => {
        if (userInfo) {
            setIsActive(userInfo.isActive ?? false);
        }
    }, [userInfo]);
    ```

- **API Update Function**: 
  - Updated the `updateUser` function to include the user ID in the URL for the update request.
  - **Code Snippet**:
    ```typescript
    const targetUserUrl = `${USERS_URL}/${user.id}`;
    ```

### Changes
- **User Service**: 
  - Refactored the `updateUser` function to use the correct API instance for making requests.
  - **Code Snippet**:
    ```typescript
    const response = await api.put(targetUserUrl, user);
    ```

- **Logging**: 
  - Added logging for user updates in the `UserRepository`.
  - **Code Snippet**:
    ```csharp
    _logger.LogInformation("User updated: {UserId}", user.Id);
    ```

### Commits
- **[ed65582]** Add mapping from User to UserDto in UserMappingProfile to resolve AutoMapperMappingException
- **[b537319]** Fix user active status handling in UserProfile component and update API endpoints
- **[ab71e91]** Update user service to include user ID in update requests
- **[aec54a6]** Add logging for user updates in UserRepository