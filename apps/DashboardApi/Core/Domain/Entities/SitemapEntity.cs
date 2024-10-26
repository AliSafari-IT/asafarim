using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashboardApi.Core.Domain.Enum;

// apps/DashboardApi/Core/Domain/Entities/SitemapEntity.cs
namespace DashboardApi.Core.Domain.Entities;
public class SitemapEntity
{
    public Guid Id { get; set; }

    // These properties are required, so they should not allow null values
    public required string PageName { get; set; }
    public required string Description { get; set; }
    public required string Slug { get; set; }

    public SitemapEntity()
    {
        Id = Guid.NewGuid();
        PageName = string.Empty;
        Description = string.Empty;
        Slug = string.Empty;
        AccessByRole = EnumUserRole.Guest;
    }

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
