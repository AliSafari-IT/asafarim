using Ganss.Xss;
using System.ComponentModel.DataAnnotations.Schema;
namespace DashboardApi.Core.Domain.Entities;

public class Panel
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; } = string.Empty;

    public string Summary { get; set; } = string.Empty;

    public DateTime DateCreated { get; private set; }

    public DateTime DateModified { get; private set; }


    public Panel()
    {
        Id = Guid.NewGuid();
        Title = string.Empty;
        DateCreated = DateTime.UtcNow;
        DateModified = DateCreated;
    }

    // Method to delete the panel
    public void Delete()
    {
        UpdateModifiedDate();
    }

    // Method to modify the panel content
    public void ModifyPanel(string newTitle, string newContent, string newSummary)
    {
        Title = newTitle;
        Content = newContent;
        Summary = newSummary;
        UpdateModifiedDate();
    }

    // Private method to update the modified date
    private void UpdateModifiedDate()
    {
        DateModified = DateTime.UtcNow;
    }

    // Sanitization methods
    public string SanitizePanel()
    {
        return $@"
                <div class='panel'>
                    <h1>{SanitizeTitle()}</h1>
                    <div>{SanitizeContent()}</div>
                    <div class='summary'>
                        <strong>Summary:</strong> {SanitizeSummary()}
                    </div>
                </div>";
    }

    public string SanitizeTitle()
    {
        var sanitizer = new HtmlSanitizer();
        return sanitizer.Sanitize(Title);
    }

    public string SanitizeContent()
    {
        var sanitizer = new HtmlSanitizer();
        return sanitizer.Sanitize(Content);
    }

    public string SanitizeSummary()
    {
        var sanitizer = new HtmlSanitizer();
        return sanitizer.Sanitize(Summary);
    }
}
