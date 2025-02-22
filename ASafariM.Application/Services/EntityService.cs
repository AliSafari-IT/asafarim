using ASafariM.Domain.Interfaces;
using Serilog;

namespace ASafariM.Application.Services
{
    public class EntityService<T> : IEntityService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly ILogger _logger;

        public EntityService(IGenericRepository<T> repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            try
            {
                return await _repository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while getting entity by ID {EntityId}", id);
                throw;
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _repository.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while getting all entities");
                throw;
            }
        }

        public async Task<T> CreateAsync(T entity)
        {
            try
            {
                await _repository.AddAsync(entity);
                return entity;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while creating entity");
                throw;
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                await _repository.UpdateAsync(entity);
                return entity;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while updating entity");
                throw;
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            try
            {
                await _repository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while deleting entity with ID {EntityId}", id);
                throw;
            }
        }

        public async Task<T[]> DeleteManyAsync(IEnumerable<Guid> ids)
        {
            try
            {
                var entities = new List<T>();
                foreach (var id in ids)
                {
                    var entity = await _repository.GetByIdAsync(id);
                    if (entity != null)
                    {
                        await _repository.DeleteAsync(id);
                        entities.Add(entity);
                    }
                }
                return entities.ToArray();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred while deleting multiple entities");
                throw;
            }
        }
    }
}
