using System;
using Core.Domain.Enum;

namespace DashboardApi.Core.Domain.Entities
{
    public class SitemapEntity
    {
        public Guid Id { get; set; }

        // These properties are required, so they should not allow null values
        public required string PageName { get; set; }
        public required string Description { get; set; }
        public required string Slug { get; set; }

        // AccessByRole will be stored as a string in the database
        public EnumUserRole AccessByRole { get; set; }

        public void ModifySitemapItem(string newPageName, string newDescription, string newSlug, EnumUserRole newAccessByRole) 
        {
            PageName = newPageName;
            Description = newDescription;
            Slug = newSlug;
            AccessByRole = newAccessByRole;
        }

        public void AddSitemapItem(string newPageName, string newDescription, string newSlug, EnumUserRole newAccessByRole) 
        {
            PageName = newPageName;
            Description = newDescription;
            Slug = newSlug;
            AccessByRole = newAccessByRole;
        }

        public void RemoveSitemapItem() 
        {
            PageName = null;
            Description = null;
            Slug = null;
            AccessByRole = EnumUserRole.Admin;
        }

        public void SetAccessByRole(EnumUserRole newAccessByRole) 
        {
            AccessByRole = newAccessByRole;
        }   

        public void SetPageName(string newPageName) 
        {
            PageName = newPageName;
        }

        public void SetDescription(string newDescription)
        {
            Description = newDescription;
        }

        public void SetSlug(string newSlug)
        {
            Slug = newSlug;
        }
    }
}
