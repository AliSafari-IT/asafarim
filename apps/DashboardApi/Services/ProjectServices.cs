
using DashboardApi.Core.Domain.Entities;
using DashboardApi.Core.Domain.Enum;
using DashboardApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DashboardApi.Services;

public class ProjectServices
{
    private readonly ApplicationDbContext _context;

    public ProjectServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Project>> GetProjectsByUserAndNameAsync(User user, string name)
    {
        return await _context.Projects
            .Where(p => p.OwnerId == user.Id && p.Title.Contains(name))
            .ToListAsync();
    }

    public async Task<List<Project>> GetProjectsAsync()
    {
        return await _context.Projects.ToListAsync();
    }

    public async Task<Project> GetProjectAsync(Guid id)
    {
        return await _context.Projects.FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Project> AddProjectAsync(Project project)
    {
        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
        return project;
    }

    public async Task UpdateProjectAsync(Project project)
    {
        _context.Projects.Update(project);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProjectAsync(Guid id)
    {
        var project = await _context.Projects.FirstOrDefaultAsync(p => p.Id == id);
        if (project != null)
        {
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
        }
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

    internal async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    internal object Entry(Project project)
    {
        var entry = _context.Entry(project);
        return entry;

    }

    internal async Task<bool> ProjectExistsAsync(Guid id)
    {
        return await _context.Projects.AnyAsync(p => p.Id == id);
    }
}