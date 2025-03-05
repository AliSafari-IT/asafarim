using ASafariM.Domain.Common;
using ASafariM.Domain.Enums;

namespace ASafariM.Domain.Entities;

public class ProjectMember : BaseEntity
{
    public Guid ProjectId { get; set; }
    public Project? Project { get; set; }

    public Guid UserId { get; set; }
    public User? User { get; set; }

    // For example, store whether the user is a normal Member, or something else
    public ProjectRoleEnum ProjectMemberType { get; set; } = ProjectRoleEnum.Owner;
}
