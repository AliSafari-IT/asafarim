using System;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities.PostRelationships
{
    public class PostCollaborator
    {
        [Key]
        public Guid Id { get; set; }

        public Guid PostId { get; set; }
        public virtual Post Post { get; set; } = null!;

        public Guid CollaboratorId { get; set; }
        public virtual User Collaborator { get; set; } = null!;

        public bool IsAdmin { get; set; }
    }
}
