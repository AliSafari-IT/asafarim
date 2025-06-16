# Feature: Enhanced Repository Link Management

Date: 2025-03-13

## Description of Changes

This update improves the repository link management functionality in the ASafariM application, focusing on both the frontend display and data handling. The changes address issues with repository links not displaying properly in the project view page and enhance the user experience when managing links in the edit project and add project pages.

### 1. Fixed Repository Link Data Processing

The API response format for repository links contained a nested structure with `$values` property that wasn't being properly processed by the frontend. We updated the `fetchEntityRepoLinks` function to handle this format correctly:

```typescript
// Before
export const fetchEntityRepoLinks = async (entityTableName: string, entityId: string) => {
  // ...
  const response = await api.get(`/${endpoint}/${entityId}/links`);
  logger.info(`Successfully fetched repository links: ${JSON.stringify(response.data)}`);
  return response.data;
  // ...
};

// After
export const fetchEntityRepoLinks = async (entityTableName: string, entityId: string) => {
  // ...
  const response = await api.get(`/${endpoint}/${entityId}/links`);
  logger.info(`Successfully fetched repository links: ${JSON.stringify(response.data)}`);
  
  // Extract the $values array from the response if it exists
  if (response.data && response.data.$values) {
    return response.data.$values;
  }
  
  // If the response is already an array, return it
  if (Array.isArray(response.data)) {
    return response.data;
  }
  
  // Otherwise, return an empty array
  return [];
  // ...
};
```

### 2. Enhanced Delete Functionality for Repository Links

The repository link deletion process in the EditProject component has been improved with:

- More expressive delete buttons with clear visual indicators
- A confirmation dialog to prevent accidental deletions
- Better styling and user feedback

```tsx
// Before
<DefaultButton 
  iconProps={{ iconName: "Delete" }}
  onClick={() => handleRemoveRepoLink(index)}
  className="ml-2"
  title="Remove Link"
/>

// After
<IconButton 
  onClick={() => confirmDeleteLink(index)}
  className="ml-2 bg-red-100 hover:bg-red-200 text-red-600 hover:text-red-700 rounded-md transition-colors duration-200"
  title="Remove Link"
  ariaLabel="Delete repository link"
>
  <Delete24Regular />
</IconButton>
```

### 3. Added Confirmation Dialog for Link Deletion

Added a confirmation dialog that shows which link is being deleted and requires user confirmation:

```tsx
{/* Delete Confirmation Dialog */}
<Dialog
  hidden={!showDeleteDialog}
  onDismiss={() => setShowDeleteDialog(false)}
  dialogContentProps={{
    type: DialogType.normal,
    title: 'Confirm Delete',
    subText: `Are you sure you want to delete this repository link?`
  }}
  modalProps={{
    isBlocking: true,
    styles: { main: { maxWidth: 450 } }
  }}
>
  {linkToDeleteIndex !== null && repoLinks[linkToDeleteIndex] && (
    <div className="mb-4 p-3 bg-gray-100 border border-gray-200 rounded-md break-all">
      <Text className="text-sm text-gray-700">{repoLinks[linkToDeleteIndex]}</Text>
    </div>
  )}
  <DialogFooter>
    <PrimaryButton 
      onClick={() => handleRemoveRepoLink()} 
      text="Delete" 
      className="bg-red-500 hover:bg-red-600 border-0 text-white"
    />
    <DefaultButton 
      onClick={() => setShowDeleteDialog(false)} 
      text="Cancel" 
    />
  </DialogFooter>
</Dialog>
```

### 4. Added Debug Logging

Added detailed console logging to help diagnose data format issues:

```typescript
console.log('Raw API response data:', response.data);
console.log('Type of response data:', typeof response.data);
console.log('Is Array?', Array.isArray(response.data));
```

### 5. Fixed Repository Links in Add Project

Fixed an issue where repository links weren't being saved when creating a new project:

#### 5.1 Updated ProjectCreateDto to Include Repository Links

```csharp
// Before
public class ProjectCreateDto
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Budget { get; set; }
    public int Visibility { get; set; }
    public int Status { get; set; }
    public Guid OwnerId { get; set; }
}

// After
public class ProjectCreateDto
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Budget { get; set; }
    public int Visibility { get; set; }
    public int Status { get; set; }
    public Guid OwnerId { get; set; }
    public List<string> RepoLinks { get; set; } = new List<string>();
}
```

#### 5.2 Enhanced ProjectsController to Handle Repository Links

Updated the CreateProject method to properly handle repository links:

```csharp
// Before
var createdProject = await _projectService.CreateAsync(project);

// After
Project createdProject;

// Check if repository links are provided
if (projectDto.RepoLinks != null && projectDto.RepoLinks.Any())
{
    _logger.LogInformation($"Creating project with {projectDto.RepoLinks.Count} repository links");
    
    // Filter out invalid links
    var validLinks = projectDto.RepoLinks
        .Where(link => !string.IsNullOrWhiteSpace(link))
        .ToList();
    
    if (validLinks.Count != projectDto.RepoLinks.Count)
    {
        _logger.LogWarning($"Filtered out {projectDto.RepoLinks.Count - validLinks.Count} invalid links");
    }
    
    // Use the CreateAsync method that accepts repository links
    createdProject = await _projectService.CreateAsync(project, validLinks);
    _logger.LogInformation($"Successfully created project with repository links: {createdProject.Name}");
}
else
{
    // Use the standard CreateAsync method without links
    createdProject = await _projectService.CreateAsync(project);
    _logger.LogInformation($"Successfully created project without repository links: {createdProject.Name}");
}
```

### 6. Redesigned AddProject Component

Completely redesigned the AddProject component to match the layout and styling of the EditProject component:

- Implemented a two-column grid layout for form fields
- Used direct form state management instead of the AddForm component
- Added consistent styling and validation
- Moved repository links section to match EditProject layout
- Added action buttons at the bottom with the same styling as EditProject

## Impact

These changes impact the following areas of the application:

1. **Project View Page**: Repository links now display correctly when viewing project details
2. **Project Edit Page**: Enhanced UI for managing repository links with better feedback and safety features
3. **Project Add Page**: Redesigned to match Edit Page layout and fixed repository link saving
4. **API Data Handling**: Improved handling of API response formats for repository links
5. **Backend DTOs and Controllers**: Updated to properly handle repository links during project creation

## Files Affected

- `ASafariM.Clients/asafarim-ui/src/api/entityServices.ts`
- `ASafariM.Clients/asafarim-ui/src/pages/Project/ViewProject.tsx`
- `ASafariM.Clients/asafarim-ui/src/pages/Project/EditProject.tsx`
- `ASafariM.Clients/asafarim-ui/src/pages/Project/AddProject.tsx`
- `ASafariM.Application/DTOs/ProjectCreateDto.cs`
- `ASafariM.Presentation/Controllers/ProjectsController.cs`

## Testing

To verify these changes:

I. **View Project Page**:
   - Navigate to a project with repository links
   - Verify that links are displayed correctly in the "Repository Links" section

II. **Edit Project Page**:
   - Navigate to edit a project
   - Add, remove, and modify repository links
   - Test the delete confirmation dialog
   - Verify visual feedback when hovering over delete buttons

III. **Add Project Page**:
   - Create a new project with repository links
   - Verify that the links are saved correctly and appear in the project view
   - Test the form layout and styling matches the edit project page
   - Verify that the repository links section appears after the form fields

IV. **API Response Handling**:
   - Check browser console logs to verify correct processing of API responses
   - Verify that links with different response formats are handled correctly

V. **Error Handling**:
   - Verify that authentication errors are handled correctly
   - Verify that other errors are handled gracefully