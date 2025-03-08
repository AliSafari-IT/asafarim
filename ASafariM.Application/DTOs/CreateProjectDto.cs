using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASafariM.Domain.Enums;

namespace ASafariM.Application.DTOs
{
    public class CreateProjectDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } = DateTime.MinValue;
        public double Budget { get; set; }
        public VisibilityEnum Visibility { get; set; } = VisibilityEnum.Private;
        public StatusEnum Status { get; set; } = StatusEnum.InProgress;
        public Guid OwnerId { get; set; }
    }
}
