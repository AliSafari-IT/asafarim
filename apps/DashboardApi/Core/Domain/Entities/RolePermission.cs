using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardApi.Core.Domain.Entities
{
    public class RolePermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Guid RoleId { get; set; }
        public Role? Role { get; set; } = null;


        [Required]
        public Guid PermissionId { get; set; }
        public Permission? Permission { get; set; } = null;

    }
}
