namespace ASafariM.Application.DTOs;

public class EmailUsernameAvailabilityDto
{
    public IsTakenDto? EmailAvailability { get; set; }
    public IsTakenDto? UsernameAvailability { get; set; }
}
