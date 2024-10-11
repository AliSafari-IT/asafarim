using System;

namespace Core.Domain.Entities
{
    public class Sitemap
    {
        public Guid Id { get; set; }

        // These properties are required, so they should not allow null values
        public required string PageName { get; set; }
        public required string Description { get; set; }
        public required string Slug { get; set; }

        // AccessByRole will be stored as a string in the database
        public Role AccessByRole { get; set; }
    }

    // Enum for user roles
    public enum Role
    {
        Guest,
        StandardUser,
        Admin
    }
}
