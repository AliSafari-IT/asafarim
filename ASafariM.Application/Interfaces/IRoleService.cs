using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;

namespace ASafariM.Application.Interfaces
{
    public interface IRoleService : IEntityService<Role>
    {
        // GetRoleByIdAsync
        Task<Role> GetRoleByIdAsync(Guid id);

        // GetRoleByNameAsync
        Task<Role> GetRoleByNameAsync(string name);

        // Add any other role-related methods here
    }
}
