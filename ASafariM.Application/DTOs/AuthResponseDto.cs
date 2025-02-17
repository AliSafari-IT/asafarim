namespace ASafariM.Application.DTOs
{
    // This DTO can be used when returning access and refresh tokens after a successful login or token refresh.
    public class AuthResponseDto
    {
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}
