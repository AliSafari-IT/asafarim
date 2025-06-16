// D:\repos\ASafariM\ASafariM.Domain\Entities\BibliographyItem.cs

using System;
using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Common;

namespace ASafariM.Domain.Entities
{
    public class BibliographyItem : BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Required]
        public int Year { get; set; }

        [StringLength(50)]
        public string Genre { get; set; }

        public bool IsRead { get; set; }

        // Navigation properties
        public Guid? AttachmentId { get; set; }
        public Attachment? Attachment { get; set; }
    }
}
