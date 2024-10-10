using System;

namespace Core.Domain.Entities
{
    public class Sitemap
    {
        public Guid Id { get; set; }
        public required string PageName { get; set; }
        public required string Description { get; set; }
        public required string Slug { get; set; }


        public Role AccessByRole { get; set; }
    }

    public enum Role
    {
        Guest,
        StandardUser,
        Admin
    }
}
