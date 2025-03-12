using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Application.DTOs;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using ASafariM.Domain.Exceptions;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ASafariM.Infrastructure.Services
{
    public class ProjectService : IProjectService
    {
        private readonly AppDbContext _dbContext;
        private readonly IUserService _userService;

        public ProjectService(AppDbContext dbContext, IUserService userService)
        {
            _dbContext = dbContext;
            _userService = userService;
        }

        public async Task<IEnumerable<Project>> GetAllAsync()
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                Log.Information("Fetching projects from the database.");
                return await _dbContext.Projects.ToListAsync();
            });
        }

        public async Task<Project> GetByIdAsync(Guid id)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                var project = await _dbContext.Projects.FindAsync(id);
                if (project == null)
                {
                    Log.Warning($"Project with ID {id} not found");
                    throw new NotFoundException($"Project with ID {id} not found");
                }
                return project;
            });
        }

        /// <summary>
        /// Checks if a project with the specified ID exists
        /// </summary>
        /// <param name="id">The ID of the project to check</param>
        /// <returns>True if the project exists, false otherwise</returns>
        public async Task<bool> ExistsAsync(Guid id)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                try
                {
                    Log.Information("Checking if project with ID {ProjectId} exists", id);
                    return await _dbContext.Projects.AnyAsync(p => p.Id == id);
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Error checking if project with ID {ProjectId} exists", id);
                    throw;
                }
            });
        }

        public async Task<Project> GetByIdWithMembersAsync(Guid id)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                var project = await _dbContext
                    .Projects.Include(p => p.ProjectMembers)
                    .FirstOrDefaultAsync(p => p.Id == id);
                if (project == null)
                {
                    Log.Warning($"Project with ID {id} not found");
                    throw new NotFoundException($"Project with ID {id} not found");
                }
                return project;
            });
        }

        public async Task<Project> GetByIdWithLinksAsync(Guid id)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                try
                {
                    Log.Information("Fetching project {ProjectId} with links", id);

                    // First, get the project without links to make sure it exists
                    var project = await _dbContext
                        .Projects.Include(p => p.Links) // Ensure links are included
                        .FirstOrDefaultAsync(p => p.Id == id);

                    if (project == null)
                    {
                        Log.Warning("Project with ID {ProjectId} not found", id);
                        throw new NotFoundException($"Project with ID {id} not found");
                    }

                    try
                    {
                        // Now try to get the links using the Include approach
                        Log.Information(
                            "Trying to fetch links for project {ProjectId} using Include",
                            id
                        );
                        var projectWithLinks = await _dbContext
                            .Projects.Include(p => p.Links)
                            .AsNoTracking()
                            .FirstOrDefaultAsync(p => p.Id == id);

                        if (projectWithLinks != null)
                        {
                            // Initialize Links collection if null to avoid NullReferenceException
                            if (projectWithLinks.Links == null)
                            {
                                Log.Warning("Links collection is null for project {ProjectId}", id);
                                projectWithLinks.Links = new List<Link>();
                            }

                            Log.Information(
                                "Successfully retrieved project {ProjectId} with {LinkCount} links using Include",
                                id,
                                projectWithLinks.Links.Count
                            );

                            return projectWithLinks;
                        }
                    }
                    catch (Exception linkEx)
                    {
                        // Log the exception but don't rethrow - we'll try the fallback approach
                        Log.Warning(
                            linkEx,
                            "Error fetching links for project {ProjectId} using Include: {ErrorMessage}",
                            id,
                            linkEx.Message
                        );
                    }

                    // If we get here, try an alternative approach to fetch links
                    try
                    {
                        Log.Information(
                            "Trying fallback approach to fetch links for project {ProjectId}",
                            id
                        );

                        // Fetch links separately (fallback)
                        var links = await _dbContext
                            .Set<Link>()
                            .AsNoTracking()
                            .Where(l => l.ProjectId == id)
                            .ToListAsync();

                        // Manually attach links to the project
                        project.Links = links;

                        Log.Information(
                            "Successfully retrieved project {ProjectId} with {LinkCount} links using fallback approach",
                            id,
                            links.Count
                        );

                        return project;
                    }
                    catch (Exception fallbackEx)
                    {
                        Log.Warning(
                            fallbackEx,
                            "Error with fallback approach for project {ProjectId}: {ErrorMessage}",
                            id,
                            fallbackEx.Message
                        );

                        // Return the project even if we couldn't get links
                        project.Links = new List<Link>();
                        return project;
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(
                        ex,
                        "Error fetching project {ProjectId} with links: {ErrorMessage}",
                        id,
                        ex.Message
                    );
                    if (ex.InnerException != null)
                    {
                        Log.Error("Inner exception: {InnerError}", ex.InnerException.Message);
                    }
                    throw; // Rethrow to be handled by the controller
                }
            });
        }

        public async Task<Project[]> GetByIdsAsync(IEnumerable<Guid> ids)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                return await _dbContext.Projects.Where(p => ids.Contains(p.Id)).ToArrayAsync();
            });
        }

        // Implementation of IEntityService<Project>.CreateAsync
        public async Task<Project> CreateAsync(Project entity)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                entity.CreatedAt = DateTime.UtcNow;
                entity.Id = entity.Id == Guid.Empty ? Guid.NewGuid() : entity.Id;
                entity.Status = entity.Status == 0 ? StatusEnum.InProgress : entity.Status;
                entity.Visibility =
                    entity.Visibility == 0 ? VisibilityEnum.Private : entity.Visibility;

                _dbContext.Projects.Add(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            });
        }

        public async Task<Project> CreateAsync(Project project, List<string> repoUrls)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                project.CreatedAt = DateTime.UtcNow;
                project.Id = project.Id == Guid.Empty ? Guid.NewGuid() : project.Id;

                var owner = await _userService.GetByIdAsync(project.OwnerId);
                if (owner == null)
                {
                    throw new InvalidOperationException(
                        $"User with ID {project.OwnerId} not found"
                    );
                }

                project.Status = project.Status == 0 ? StatusEnum.InProgress : project.Status;
                project.Visibility =
                    project.Visibility == 0 ? VisibilityEnum.Private : project.Visibility;

                // Attach repositories
                project.Links = repoUrls
                    .Select(url => new Link(url, "Repository", "Project repository link")
                    {
                        ProjectId = project.Id,
                    })
                    .ToList();

                _dbContext.Projects.Add(project);
                await _dbContext.SaveChangesAsync();
                return project;
            });
        }

        public async Task UpdateAsync(Project project)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            await strategy.ExecuteAsync(async () =>
            {
                var existingProject = await _dbContext.Projects.FindAsync(project.Id);
                if (existingProject == null)
                {
                    throw new NotFoundException($"Project with ID {project.Id} not found");
                }

                existingProject.Name = project.Name;
                existingProject.Description = project.Description;
                existingProject.StartDate = project.StartDate;
                existingProject.EndDate = project.EndDate;
                existingProject.Budget = project.Budget;
                existingProject.Status = project.Status;
                existingProject.Visibility = project.Visibility;
                existingProject.UpdatedAt = DateTime.UtcNow;

                _dbContext.Projects.Update(existingProject);
                await _dbContext.SaveChangesAsync();
                Log.Information("Project updated successfully: {ProjectId}", project.Id);
            });
        }

        public async Task UpdateAsync(Project project, List<string> repoUrls)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();

            await strategy.ExecuteAsync(async () =>
            {
                using var transaction = await _dbContext.Database.BeginTransactionAsync();

                try
                {
                    if (project == null)
                        throw new ArgumentNullException(nameof(project), "Project cannot be null");

                    Log.Information(
                        "Updating project {ProjectId} with {LinkCount} repository links",
                        project.Id,
                        repoUrls?.Count ?? 0
                    );

                    var existingProject = await _dbContext.Projects.FindAsync(project.Id);
                    if (existingProject == null)
                        throw new NotFoundException($"Project with ID {project.Id} not found");

                    // Step 1: Update Project Properties
                    existingProject.Name = project.Name;
                    existingProject.Description = project.Description;
                    existingProject.StartDate = project.StartDate;
                    existingProject.EndDate = project.EndDate;
                    existingProject.Budget = project.Budget;
                    existingProject.Status = project.Status;
                    existingProject.Visibility = project.Visibility;
                    existingProject.UpdatedAt = DateTime.UtcNow;

                    await _dbContext.SaveChangesAsync();

                    Log.Information(
                        "Successfully updated basic project properties for {ProjectId}",
                        project.Id
                    );

                    // Step 2: Remove Existing Repository Links
                    await _dbContext.Database.ExecuteSqlRawAsync(
                        "DELETE FROM Links WHERE ProjectId = {0}",
                        project.Id
                    );

                    Log.Information(
                        "Successfully deleted existing repository links for {ProjectId}",
                        project.Id
                    );

                    // Step 3: Insert New Repository Links
                    if (repoUrls != null && repoUrls.Any())
                    {
                        var newLinks = repoUrls
                            .Select(url => new Link(url, "Repository", "Project repository link")
                            {
                                Id = Guid.NewGuid(),
                                ProjectId = project.Id,
                                CreatedAt = DateTime.UtcNow,
                            })
                            .ToList();

                        await _dbContext.Links.AddRangeAsync(newLinks);
                        await _dbContext.SaveChangesAsync();

                        Log.Information(
                            "Successfully added {LinkCount} new links for {ProjectId}",
                            newLinks.Count,
                            project.Id
                        );
                    }

                    // Commit Transaction
                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    Log.Error(
                        ex,
                        "Error updating project {ProjectId}: {ErrorMessage}",
                        project.Id,
                        ex.Message
                    );
                    await transaction.RollbackAsync();
                    throw;
                }
            });
        }

        public async Task DeleteAsync(Guid id)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            await strategy.ExecuteAsync(async () =>
            {
                var project = await _dbContext.Projects.FindAsync(id);
                if (project == null)
                {
                    throw new NotFoundException($"Project with ID {id} not found");
                }

                _dbContext.Projects.Remove(project);
                await _dbContext.SaveChangesAsync();
                Log.Information("Project deleted successfully: {ProjectId}", id);
            });
        }

        public async Task<Project[]> DeleteManyAsync(IEnumerable<Guid> ids)
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                var projects = await _dbContext
                    .Projects.Where(p => ids.Contains(p.Id))
                    .ToArrayAsync();
                if (projects.Length == 0)
                {
                    throw new NotFoundException("One or more projects not found");
                }
                _dbContext.Projects.RemoveRange(projects);
                await _dbContext.SaveChangesAsync();
                Log.Information(
                    "Projects deleted successfully: {ProjectIds}",
                    string.Join(", ", ids)
                );
                return projects;
            });
        }

        public async Task<Project[]> GetAllWithMembersAsync()
        {
            var strategy = _dbContext.Database.CreateExecutionStrategy();
            return await strategy.ExecuteAsync(async () =>
            {
                Log.Information("Fetching all projects with members.");
                var projects = await _dbContext
                    .Projects.Include(p => p.ProjectMembers)
                    .ToArrayAsync();
                Log.Information("Fetched {ProjectCount} projects with members.", projects.Length);
                return projects;
            });
        }
    }
}
