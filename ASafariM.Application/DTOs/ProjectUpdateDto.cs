using System;
using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Enums;

namespace ASafariM.Application.DTOs;

public class ProjectUpdateDto
{
    [Required]
    [MaxLength(120)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Budget must be a positive value.")]
    public double? Budget { get; set; }

    [EnumDataType(typeof(StatusEnum))]
    public StatusEnum? Status { get; set; }

    [EnumDataType(typeof(VisibilityEnum))]
    public VisibilityEnum? Visibility { get; set; }
}
