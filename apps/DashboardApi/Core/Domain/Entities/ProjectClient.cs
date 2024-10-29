using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardApi.Core.Domain.Entities
{
    public class ProjectClient
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; } 

        public Guid ClientId { get; set; }
        public virtual User Client { get; set; }
    }
}
