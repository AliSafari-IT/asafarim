using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASafariM.Domain.Entities.PostRelationships
{
    public class PostRelatedPost
    {
        public Guid PostId { get; set; }
        public Post Post { get; set; }

        public Guid RelatedPostId { get; set; }
        public Post RelatedPost { get; set; }
    }
}
