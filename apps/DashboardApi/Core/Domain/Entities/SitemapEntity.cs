using System;
using DashboardApi.Core.Domain.Enum;

namespace DashboardApi.Core.Domain.Entities
{
    public class SitemapEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Automatically generates a unique Guid for each SitemapEntity instance.

        // These properties are required, so they should not allow null values
        public required string PageName { get; set; } = string.Empty;
        public required string Description { get; set; } = string.Empty;
        public required string Slug { get; set; } = string.Empty;

        // AccessByRole will be stored as a string in the database
        public EnumUserRole AccessByRole { get; set; } = EnumUserRole.Guest;

        // Constructor for initializing SitemapEntity
        public SitemapEntity() { }

        public SitemapEntity(string pageName, string description, string slug, EnumUserRole accessByRole)
        {
            PageName = pageName;
            Description = description;
            Slug = slug;
            AccessByRole = accessByRole;
        }

        public void ModifySitemapItem(string newPageName, string newDescription, string newSlug, EnumUserRole newAccessByRole)
        {
            PageName = newPageName;
            Description = newDescription;
            Slug = newSlug;
            AccessByRole = newAccessByRole;
        }

        public void RemoveSitemapItem()
        {
            // You can implement a flag to mark this item as deleted instead of nullifying fields
            // Example: IsDeleted = true; (ensure you have an IsDeleted property)
        }

        public void SetAccessByRole(EnumUserRole newAccessByRole) => AccessByRole = newAccessByRole;

        public void SetPageName(string newPageName) => PageName = newPageName;

        public void SetDescription(string newDescription) => Description = newDescription;

        public void SetSlug(string newSlug) => Slug = newSlug;
    }
}
