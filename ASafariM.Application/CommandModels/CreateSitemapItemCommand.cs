using System;
using System.Collections.Generic;
using ASafariM.Domain.Enums;

namespace ASafariM.Application.CommandModels
{
    public class CreateSitemapItemCommand
    {
        public string PageName { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public RoleEnum AccessByRole { get; set; }
        public Guid? ParentId { get; set; }
        public int Order { get; set; }
        public string Icon { get; set; }
        public bool IsExternalLink { get; set; }
        public string ExternalLink { get; set; }
        public bool IsHidden { get; set; }
        public bool IsPublished { get; set; }
        public ICollection<Guid> TopicIds { get; set; }
    }

    public class UpdateSitemapItemCommand : CreateSitemapItemCommand
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDisabled { get; set; }
    }
}
