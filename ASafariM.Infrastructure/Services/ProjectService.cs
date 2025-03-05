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
            Log.Information("Fetching projects from the database.");
            return await _dbContext.Projects.ToListAsync();
        }

        public async Task<Project> GetByIdAsync(Guid id)
        {
            var project = await _dbContext.Projects.FindAsync(id);
            if (project == null)
            {
                Log.Warning($"Project with ID {id} not found");
                throw new NotFoundException($"Project with ID {id} not found");
            }
            return project;
        }

        public async Task<Project> GetByIdWithMembersAsync(Guid id)
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
        }

        public async Task<Project[]> GetByIdsAsync(IEnumerable<Guid> ids)
        {
            return await _dbContext.Projects.Where(p => ids.Contains(p.Id)).ToArrayAsync();
        }

        public async Task<Project> CreateAsync(Project project)
        {
            Log.Information("Creating new project: {@Project}", project);
            project.CreatedAt = DateTime.UtcNow;
            project.Id = project.Id == Guid.Empty ? Guid.NewGuid() : project.Id;

            var owner = await _userService.GetByIdAsync(project.OwnerId);
            if (owner == null)
            {
                throw new InvalidOperationException($"User with ID {project.OwnerId} not found");
            }

            project.Status = project.Status == 0 ? StatusEnum.InProgress : project.Status;
            project.Visibility =
                project.Visibility == 0 ? VisibilityEnum.Private : project.Visibility;

            _dbContext.Projects.Add(project);
            await _dbContext.SaveChangesAsync();
            Log.Information("Project created successfully: {ProjectId}", project.Id);
            return project;
        }

        public async Task UpdateAsync(Project project)
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
        }

        public async Task DeleteAsync(Guid id)
        {
            var project = await _dbContext.Projects.FindAsync(id);
            if (project == null)
            {
                throw new NotFoundException($"Project with ID {id} not found");
            }

            _dbContext.Projects.Remove(project);
            await _dbContext.SaveChangesAsync();
            Log.Information("Project deleted successfully: {ProjectId}", id);
        }

        public async Task<Project[]> DeleteManyAsync(IEnumerable<Guid> ids)
        {
            var projects = await _dbContext.Projects.Where(p => ids.Contains(p.Id)).ToArrayAsync();
            if (projects.Length == 0)
            {
                throw new NotFoundException("One or more projects not found");
            }
            _dbContext.Projects.RemoveRange(projects);
            await _dbContext.SaveChangesAsync();
            Log.Information("Projects deleted successfully: {ProjectIds}", string.Join(", ", ids));
            return projects;
        }

        public async Task<Project[]> GetAllWithMembersAsync()
        {
            Log.Information("Fetching all projects with members.");
            var projects = await _dbContext.Projects.Include(p => p.ProjectMembers).ToArrayAsync();
            Log.Information("Fetched {ProjectCount} projects with members.", projects.Length);
            return projects;
        }
    }
}
