using System;

namespace ASafariM.Domain.Entities;

/// <summary>
/// Represents a visitor log entry for tracking website visits
/// </summary>
public class VisitorLog
{
    /// <summary>
    /// Unique identifier for the visitor log entry
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// IP address of the visitor
    /// </summary>
    public string IPAddress { get; set; }

    /// <summary>
    /// Date and time of the visit in UTC
    /// </summary>
    public DateTime VisitDate { get; set; }

    /// <summary>
    /// User agent string from the visitor's browser
    /// </summary>
    public string? UserAgent { get; set; }

    /// <summary>
    /// Referrer URL if available
    /// </summary>
    public string? Referrer { get; set; }

    /// <summary>
    /// Page or endpoint that was visited
    /// </summary>
    public string? Path { get; set; }

    /// <summary>
    /// Flag to indicate if this is a unique visitor (based on IP + UserAgent)
    /// </summary>
    public bool IsUnique { get; set; }

    /// <summary>
    /// Optional session identifier
    /// </summary>
    public string? SessionId { get; set; }
}
