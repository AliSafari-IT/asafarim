using System.ComponentModel.DataAnnotations;

namespace ASafariM.Application.DTOs;

public class ProjectCreateDto
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
