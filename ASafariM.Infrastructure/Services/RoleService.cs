using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Application.Interfaces;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace ASafariM.Infrastructure.Services
{
    public class RoleService : IRoleService
    {
        private readonly AppDbContext _context;

        public RoleService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Role> GetByIdAsync(Guid id)
        {
            Log.Information($"Getting role by ID: {id}");
            var role = await _context.Roles.FindAsync(id);
            if (role == null)
            {
                Log.Warning("Role not found for ID: {RoleId}", id);
                return null;
            }

            Log.Information("Role retrieved successfully.");
            return role;
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            Log.Information("Getting all roles.");
            return await _context.Roles.ToListAsync();
        }

        public async Task<Role> AddAsync(Role entity)
        {
            Log.Information("Adding role: {@Role}", entity);
            _context.Roles.Add(entity);
            await _context.SaveChangesAsync();
            Log.Information("Role added successfully.");
            return entity;
        }

        public async Task UpdateAsync(Role entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            Log.Information("Updating role: {@Role}", entity);
            await _context.SaveChangesAsync();
            Log.Information("Role updated successfully.");
        }

        public async Task<Role[]> DeleteManyAsync(IEnumerable<Guid> ids)
        {
            var roles = await _context.Roles.Where(r => ids.Contains(r.Id)).ToArrayAsync();
            Log.Information("Deleting {RoleCount} roles", roles?.Length ?? 0);
            if (roles.Any())
            {
                _context.Roles.RemoveRange(roles);
                await _context.SaveChangesAsync();
                Log.Information("Roles deleted successfully.");
            }
            return roles;
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            Log.Information("Fetching all roles.");
            var roles = await GetAllAsync();
            Log.Information("Retrieved {RoleCount} roles", roles?.Count() ?? 0);
            return roles;
        }

        public async Task<Role> GetRoleByIdAsync(Guid id)
        {
            Log.Information($"Getting role by ID: {id}");
            var role = await GetByIdAsync(id);
            Log.Information("Role retrieved successfully.");
            return role;
        }

        public async Task<Role> GetRoleByNameAsync(string name)
        {
            Log.Information($"Getting role by name: {name}");
            var role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == name);
            if (role == null)
            {
                Log.Warning("Role not found by name: {RoleName}", name);
                return null;
            }
            Log.Information("Role retrieved successfully by name: {RoleName}", name);
            return role;
        }

        public async Task<Role> CreateAsync(Role entity)
        {
            Log.Information("Adding role: {@Role}", entity);
            _context.Roles.Add(entity);
            await _context.SaveChangesAsync();
            Log.Information("Role added successfully.");
            return entity;
        }

        public async Task DeleteAsync(Guid id)
        {
            Log.Information("Deleting role with ID: {RoleId}", id);
            var role = await _context.Roles.FindAsync(id);
            if (role != null)
            {
                _context.Roles.Remove(role);
                await _context.SaveChangesAsync();
                Log.Information("Role deleted successfully.");
            }
        }
    }
}
