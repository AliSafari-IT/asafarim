using DashboardApi.Core.Domain.Entities;
using DashboardApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DashboardApi.Services;
public class ProjectService
{
    private readonly ApplicationDbContext _context;
    public ProjectService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Project> GetProjectByIdAsync(Guid id)
    {
        return await _context.Projects
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Project> GetProjectByNameAsync(string name)
    {
        return await _context.Projects
            .FirstOrDefaultAsync(p => p.Title == name);
    }

    public async Task<List<Project>> GetProjectsAsync()
    {
        return await _context.Projects.ToListAsync();
    }

    public async Task<Project> AddProjectAsync(Project project)
    {
        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
        return project;
    }

    public async Task<Project> UpdateProjectAsync(Project project)
    {
        _context.Projects.Update(project);
        await _context.SaveChangesAsync();
        return project;
    }

    public async Task DeleteProjectAsync(Project project)
    {
        _context.Projects.Remove(project);
        await _context.SaveChangesAsync();
    }

    public async Task MarkAsCompletedAsync(Project project)
    {
        project.IsCompleted = true;
        _context.Projects.Update(project);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Project>> GetProjectsByUserAsync(User user)
    {
        return await _context.Projects
            .Where(p => p.OwnerId == user.Id)
            .ToListAsync();
    }

    public async Task<List<Project>> GetProjectsByUserAndNameAsync(User user, string name)
    {
        return await _context.Projects
            .Where(p => p.OwnerId == user.Id && p.Title.Contains(name))
            .ToListAsync();
    }
}