namespace ASafariM.Application.DTOs
{
    public class ContributorDto
    {
        public Guid UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? UserName { get; set; }
        public string? PenName { get; set; }
        public string? ProfilePicture { get; set; }
        public bool IsAdmin { get; set; }
    }
}
