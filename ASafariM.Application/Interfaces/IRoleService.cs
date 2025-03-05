using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;

namespace ASafariM.Application.Interfaces
{
    public interface IRoleService : IEntityService<Role>
    {
        // Add any additional methods specific to role management here, if needed
        Task<Role> CreateAsync(Role entity);
    }
}
