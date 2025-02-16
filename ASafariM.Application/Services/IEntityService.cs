namespace ASafariM.Application.Services
{
    public interface IEntityService<T>
        where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<T[]> DeleteManyAsync(IEnumerable<Guid> ids);
    }
}
