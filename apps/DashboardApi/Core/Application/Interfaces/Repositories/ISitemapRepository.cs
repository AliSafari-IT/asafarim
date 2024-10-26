using System.Collections.Generic;
using System.Linq.Expressions;
using DashboardApi.Core.Domain.Entities;
using DashboardApi.Core.Domain.Enum;

namespace DashboardApi.Core.Application.Interfaces.Repositories;
public interface ISitemapRepository : IRepository<SitemapEntity>, IRepository<SitemapItem>
{
    IEnumerable<SitemapEntity> GetAllSitemapItems();

}

public class SitemapItem
{
    public Guid Id { get; set; }
    public string PageName { get; set; }
    public string Description { get; set; }
    public string Slug { get; set; }
    public EnumUserRole AccessByRole { get; set; } = EnumUserRole.Admin;


}

