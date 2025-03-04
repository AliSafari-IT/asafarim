using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ASafariM.Infrastructure.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly AppDbContext _context;
    private readonly ILogger _logger;

    public ProjectRepository(AppDbContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<IEnumerable<Project>> GetAllAsync()
    {
        return await _context.Projects.Include(p => p.ProjectMembers).ToListAsync();
    }

    public async Task<Project?> GetByIdAsync(Guid id)
    {
        try
        {
            return await _context
                .Projects.Include(p => p.ProjectMembers)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while fetching project with ID {ProjectId}", id);
            throw;
        }
    }

    public async Task<Project> AddAsync(Project project)
    {
        try
        {
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
            return project;
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while adding project");
            throw;
        }
    }

    public async Task UpdateAsync(Project project)
    {
        try
        {
            _context.Entry(project).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.Error(
                ex,
                "Error occurred while updating project with ID {ProjectId}",
                project.Id
            );
            throw;
        }
    }

    public async Task DeleteAsync(Guid id)
    {
        try
        {
            var project = await _context.Projects.FindAsync(id);
            if (project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Error occurred while deleting project with ID {ProjectId}", id);
            throw;
        }
    }
}
