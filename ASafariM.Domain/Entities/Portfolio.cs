using ASafariM.Domain.Common;
using ASafariM.Domain.Enums;

namespace ASafariM.Domain.Entities;

public class Portfolio : BaseEntity
{
    public Guid OwnerId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string AboutMarkdown { get; set; } = string.Empty;
    public string ExperienceMarkdown { get; set; } = string.Empty;
    public string PublicationsMarkdown { get; set; } = string.Empty;
    public string FundingMarkdown { get; set; } = string.Empty;
    public VisibilityEnum Visibility { get; set; } = VisibilityEnum.Public;

    public User Owner { get; set; } = null!;
}
