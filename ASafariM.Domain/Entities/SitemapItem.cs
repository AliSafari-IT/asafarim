using System;
using System.Collections.Generic;
using ASafariM.Domain.Enums;

namespace ASafariM.Domain.Entities
{
    public class SitemapItem
    {
        public SitemapItem()
        {
            Children = new HashSet<SitemapItem>();
            Topics = new HashSet<Topic>();
        }

        public Guid Id { get; set; }
        public string PageName { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public RoleEnum AccessByRole { get; set; }
        public Guid? ParentId { get; set; }
        public int Order { get; set; }
        public string Icon { get; set; }
        public bool IsActive { get; set; }
        public bool IsExternalLink { get; set; }
        public string ExternalLink { get; set; }
        public bool IsHidden { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Version { get; set; }
        public bool IsPublished { get; set; }
        public string PublishedBy { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string UnpublishBy { get; set; }
        public DateTime? UnpublishDate { get; set; }
        public bool IsUnpublished { get; set; }
        public bool IsDraft { get; set; }
        public bool IsArchived { get; set; }
        public string ArchivedBy { get; set; }
        public DateTime? ArchivedDate { get; set; }

        // ParentItem
        public Guid? ParentItemId { get; set; }

        // ChildItems
        public ICollection<SitemapItem>? ChildItems { get; set; }

        // Topics
        public ICollection<Topic>? Topics { get; set; }

        // Navigation properties
        public SitemapItem? Parent { get; set; }
        public ICollection<SitemapItem>? Children { get; set; }

        public string Url { get; set; }
        public DateTime LastModified { get; set; }
        public string ChangeFrequency { get; set; }
        public double Priority { get; set; }
    }
}
