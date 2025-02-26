using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASafariM.Application.Interfaces;

public interface IEntityService<T>
    where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task<T> CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(Guid id);
}
