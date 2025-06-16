using System.Collections.Generic;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;

namespace ASafariM.Application.DTOs;

public class ProjectDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public double? Budget { get; set; }
    public StatusEnum Status { get; set; }
    public VisibilityEnum Visibility { get; set; }

    public List<string> RepositoryLinks { get; set; } = new List<string>(); // Only store URLs
}
