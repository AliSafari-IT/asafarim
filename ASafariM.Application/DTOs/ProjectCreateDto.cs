using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASafariM.Application.DTOs;

public class ProjectCreateDto
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Budget { get; set; }
    public int Visibility { get; set; }
    public int Status { get; set; }
    public Guid OwnerId { get; set; }
    public List<string> RepoLinks { get; set; } = new List<string>();
}
