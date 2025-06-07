namespace ASafariM.Application.DTOs
{
    public class CheckAvailabilityResponse
    {
        public bool IsAvailable { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
    }
}
