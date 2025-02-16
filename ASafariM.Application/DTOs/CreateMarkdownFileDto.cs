using ASafariM.Domain.Enums;

namespace ASafariM.Application.DTOs
{
    public class CreateMarkdownFileDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Path { get; set; }
        public VisibilityEnum Visibility { get; set; }

        public CreateMarkdownFileDto()
        {
            Title = string.Empty;
            Content = string.Empty;
            Path = string.Empty;
            Visibility = VisibilityEnum.Public;
        }
    }
}
