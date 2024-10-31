// Permission.cs


using System.ComponentModel.DataAnnotations;

namespace DashboardApi.Core.Domain.Entities
{
    public class Permission
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}