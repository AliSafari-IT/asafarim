using ASafariM.Domain.Enums;

namespace ASafariM.Domain.Entities;

public class MarkdownFileUser
{
    public Guid MarkdownFileId { get; set; }
    public Guid UserId { get; set; }

    // Navigation Properties
    public MarkdownFile MarkdownFile { get; set; } = null!;
    public User User { get; set; } = null!;

    // Example of extra fields
    public DateTime DateCollaborated { get; set; }
    public DateTime? CollaborationStopDate { get; set; }
    public CollaborationRoleEnum CollaborationRole { get; set; } =
        CollaborationRoleEnum.Contributor;
}
