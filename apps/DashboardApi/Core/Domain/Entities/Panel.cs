using Ganss.Xss;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DashboardApi.Core.Domain.Entities;

public class Panel
{
    [Key]
    public Guid Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; } = string.Empty;

    public string Summary { get; set; } = string.Empty;

    public DateTime DateCreated { get; private set; }

    public DateTime DateModified { get; private set; }


    public Panel()
    {
        Id = Guid.NewGuid();
        Title = string.Empty;
        DateCreated = DateTime.UtcNow;
        DateModified = DateCreated;
    }
}
