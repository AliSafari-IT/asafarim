namespace ASafariM.Application.DTOs
{
    public class CreateProjectDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Budget { get; set; }
        public int Visibility { get; set; }
        public int Status { get; set; }
        public Guid OwnerId { get; set; }
    }
}
