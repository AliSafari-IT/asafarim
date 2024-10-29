using System.Collections.Generic;
using System.Linq.Expressions;
using DashboardApi.Core.Application.Interfaces.Repositories;
using DashboardApi.Core.Domain.Entities;
using DashboardApi.Core.Domain.Enum;

namespace DashboardApi.Infrastructure.Data.Repositories;
public class SitemapRepository : ISitemapRepository
{
    public Task<SitemapEntity> AddAsync(SitemapEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<SitemapItem> AddAsync(SitemapItem entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnyAsync(Expression<Func<SitemapEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnyAsync(Expression<Func<SitemapItem, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(Expression<Func<SitemapEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(Expression<Func<SitemapEntity, bool>> predicate, Func<IQueryable<SitemapEntity>, IOrderedQueryable<SitemapEntity>> orderBy)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(Expression<Func<SitemapEntity, bool>> predicate, Func<IQueryable<SitemapEntity>, IOrderedQueryable<SitemapEntity>> orderBy, int? skip, int? take)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(Expression<Func<SitemapItem, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(Expression<Func<SitemapItem, bool>> predicate, Func<IQueryable<SitemapItem>, IOrderedQueryable<SitemapItem>> orderBy)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(Expression<Func<SitemapItem, bool>> predicate, Func<IQueryable<SitemapItem>, IOrderedQueryable<SitemapItem>> orderBy, int? skip, int? take)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(SitemapEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(SitemapItem entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapEntity>> FindAsync(Expression<Func<SitemapEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapEntity>> FindAsync(Expression<Func<SitemapEntity, bool>> predicate, Func<IQueryable<SitemapEntity>, IOrderedQueryable<SitemapEntity>> orderBy, int? skip, int? take)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapItem>> FindAsync(Expression<Func<SitemapItem, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapItem>> FindAsync(Expression<Func<SitemapItem, bool>> predicate, Func<IQueryable<SitemapItem>, IOrderedQueryable<SitemapItem>> orderBy, int? skip, int? take)
    {
        throw new NotImplementedException();
    }

    public Task<SitemapEntity> FirstOrDefaultAsync(Expression<Func<SitemapEntity, bool>> predicate, Func<IQueryable<SitemapEntity>, IOrderedQueryable<SitemapEntity>> orderBy, int? skip, int? take)
    {
        throw new NotImplementedException();
    }

    public Task<SitemapEntity> FirstOrDefaultAsync(Expression<Func<SitemapEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<SitemapEntity> FirstOrDefaultAsync(Expression<Func<SitemapEntity, bool>> predicate, Func<IQueryable<SitemapEntity>, IOrderedQueryable<SitemapEntity>> orderBy)
    {
        throw new NotImplementedException();
    }

    public Task<SitemapItem> FirstOrDefaultAsync(Expression<Func<SitemapItem, bool>> predicate, Func<IQueryable<SitemapItem>, IOrderedQueryable<SitemapItem>> orderBy, int? skip, int? take)
    {
        throw new NotImplementedException();
    }

    public Task<SitemapItem> FirstOrDefaultAsync(Expression<Func<SitemapItem, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<SitemapItem> FirstOrDefaultAsync(Expression<Func<SitemapItem, bool>> predicate, Func<IQueryable<SitemapItem>, IOrderedQueryable<SitemapItem>> orderBy)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    // Simulating data; in real use, this could be fetched from a database.
    public IEnumerable<SitemapEntity> GetAllSitemapItems()
    {
        return new List<SitemapEntity>
            {
                new() { Id = Guid.NewGuid(), PageName = "Home", Description = "Home Page", Slug = "/", AccessByRole = EnumUserRole.Guest },
                new() { Id = Guid.NewGuid(), PageName = "About", Description = "About Us", Slug = "/about", AccessByRole = EnumUserRole.Guest },
                new() { Id = Guid.NewGuid(), PageName = "Contact", Description = "Contact Us", Slug = "/contact", AccessByRole = EnumUserRole.StandardUser },
                new() { Id = Guid.NewGuid(), PageName = "Dashboard", Description = "Admin Dashboard", Slug = "/dashboard", AccessByRole = EnumUserRole.Admin }
            };
    }

    public Task<SitemapEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapEntity>> GetPagedReponseAsync(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapEntity>> GetPagedReponseAsync(int pageNumber, int pageSize, Func<IQueryable<SitemapEntity>, IOrderedQueryable<SitemapEntity>> orderBy)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapEntity>> GetPagedReponseAsync(int pageNumber, int pageSize, Expression<Func<SitemapEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapEntity>> GetPagedReponseAsync(int pageNumber, int pageSize, Expression<Func<SitemapEntity, bool>> predicate, Func<IQueryable<SitemapEntity>, IOrderedQueryable<SitemapEntity>> orderBy)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapItem>> GetPagedReponseAsync(int pageNumber, int pageSize, Func<IQueryable<SitemapItem>, IOrderedQueryable<SitemapItem>> orderBy)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapItem>> GetPagedReponseAsync(int pageNumber, int pageSize, Expression<Func<SitemapItem, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SitemapItem>> GetPagedReponseAsync(int pageNumber, int pageSize, Expression<Func<SitemapItem, bool>> predicate, Func<IQueryable<SitemapItem>, IOrderedQueryable<SitemapItem>> orderBy)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SitemapEntity> SingleOrDefaultAsync(Expression<Func<SitemapEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<SitemapEntity> SingleOrDefaultAsync(Expression<Func<SitemapEntity, bool>> predicate, Func<IQueryable<SitemapEntity>, IOrderedQueryable<SitemapEntity>> orderBy)
    {
        throw new NotImplementedException();
    }

    public Task<SitemapItem> SingleOrDefaultAsync(Expression<Func<SitemapItem, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<SitemapItem> SingleOrDefaultAsync(Expression<Func<SitemapItem, bool>> predicate, Func<IQueryable<SitemapItem>, IOrderedQueryable<SitemapItem>> orderBy)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(SitemapEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(SitemapItem entity)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<SitemapItem>> IRepository<SitemapItem>.GetAllAsync()
    {
        throw new NotImplementedException();
    }

    Task<SitemapItem> IRepository<SitemapItem>.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<SitemapItem>> IRepository<SitemapItem>.GetPagedReponseAsync(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }
}
