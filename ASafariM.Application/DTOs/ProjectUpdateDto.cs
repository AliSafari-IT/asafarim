using System;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.DTOs;

public class ProjectUpdateDto
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public double? Budget { get; set; }
    public int? Status { get; set; } // Assuming enum mapping
    public int? Visibility { get; set; } // Assuming enum mapping
}

