using System;
using System.ComponentModel.DataAnnotations;

namespace DashboardApi.Core.Domain.Entities
{
    public class PanelPost
    {
        [Key]
        public Guid PanelId { get; set; }
        public virtual Panel? Panel { get; set; }

        [Key]
        public Guid PostId { get; set; }
        public virtual BlogPost? Post { get; set; } = null;
    }
}
