namespace ASafariM.Application.CommandModels;

public class UpdateProfileCommand
{
    public Guid UserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? UserName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Country { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? Address { get; set; }
    public string? ProfilePicture { get; set; }
    public string? Biography { get; set; }
    public string? Remark { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Gender { get; set; }
    public string? Nationality { get; set; }
    public List<string>? Roles { get; set; }
}
