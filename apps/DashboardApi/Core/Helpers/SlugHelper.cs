using System;
using System.Text.RegularExpressions;

namespace DashboardApi.Core.Helpers
{
    public static class SlugHelper
    {
        public static string GenerateSlug(string phrase)
        {
            if (string.IsNullOrWhiteSpace(phrase))
                return string.Empty;

            // Remove invalid characters
            string slug = Regex.Replace(phrase.ToLowerInvariant(), @"[^a-z0-9\s-]", string.Empty);

            // Replace multiple spaces or hyphens with a single hyphen
            slug = Regex.Replace(slug, @"[\s-]+", "-").Trim('-');

            return slug;
        }
    }
}
