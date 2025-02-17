namespace ASafariM.Application.Utils
{
    public class SlugGenerator
    {
        public static string GenerateSlug(string name)
        {
            // Implement slug generation logic here
            // Example: Remove special characters, convert to lowercase, etc.
            // For simplicity, let's just return the name as is
            // In a real-world scenario, you would use a more sophisticated algorithm.
            return name.ToLower()
                .Replace(" ", "-")
                .Replace(".", "-")
                .Replace(",", "-")
                .Replace("!", "-")
                .Replace("@", "-")
                .Replace("#", "-")
                .Replace("$", "-")
                .Replace("%", "-")
                .Replace("^", "-")
                .Replace("&", "-")
                .Replace("*", "-")
                .Replace("(", "-")
                .Replace(")", "-")
                .Replace("+", "-")
                .Replace("=", "-")
                .Replace("~", "-")
                .Replace("|", "-");
        }
    }
}
