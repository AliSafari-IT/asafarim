using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASafariM.Domain.Interfaces
{
    public interface IGenericRepository<T>
        where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(Guid id);
        Task<T[]> DeleteManyAsync(IEnumerable<Guid> ids);
    }
}