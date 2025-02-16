using System;
using ASafariM.Application.DTOs;

namespace ASafariM.Application.DTOs;

public class ThemePreferenceDto
{
    public bool IsDarkTheme { get; set; }
    public string FontSize { get; set; } = string.Empty;
    public string AccentColor { get; set; } = string.Empty;
    public required string Name { get; set; } = "Default Name";
    public required string Value { get; set; } = "Default Value";
    public LanguagePreferenceDto? Language { get; set; } = null!;
}
