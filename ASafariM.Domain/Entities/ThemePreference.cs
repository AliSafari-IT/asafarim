using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Enums;
using ASafariM.Domain.Interfaces;

namespace ASafariM.Domain.Entities
{
    public class ThemePreference
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsDarkTheme { get; set; } = false;
        public required string FontSize { get; set; } = "14px";
        public required LanguagePreference Language { get; set; } = new();
        public Guid LanguageId { get; set; }
        public required string AccentColor { get; set; } = "#FF0000";
        public required string BackgroundColor { get; set; } = "#FFFFFF";
        public required string PrimaryColor { get; set; } = "#000000";
        public required string SecondaryColor { get; set; } = "#333333";
        public required string TertiaryColor { get; set; } = "#666666";
        public required string DarkModeTextColor { get; set; } = "#FFFFFF";
        public required string LightModeTextColor { get; set; } = "#000000";
        public required string DarkModeBackgroundColor { get; set; } = "#000000";
        public required string LightModeBackgroundColor { get; set; } = "#FFFFFF";
        public required string DarkModePrimaryColor { get; set; } = "#000000";
        public required string LightModePrimaryColor { get; set; } = "#FFFFFF";

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool IsDarkModeEnabled { get; set; } = false;
        public bool IsHighContrastModeEnabled { get; set; } = false;
        public bool IsReducedMotionEnabled { get; set; } = false;
    }
}
