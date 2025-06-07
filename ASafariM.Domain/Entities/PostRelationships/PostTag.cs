using System;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities.PostRelationships
{
    public class PostTag
    {
        [Key]
        public Guid Id { get; set; }

        public Guid PostId { get; set; }
        public virtual Post Post { get; set; } = null!;

        public Guid TagId { get; set; }
        public virtual Tag Tag { get; set; } = null!;
    }
}
