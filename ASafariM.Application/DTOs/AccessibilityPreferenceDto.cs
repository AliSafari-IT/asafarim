using ASafariM.Domain.Entities;

namespace ASafariM.Application.DTOs
{
    public class AccessibilityPreferenceDto
    {
        public bool EnableHighContrastMode { get; set; }
        public bool EnableScreenReaderSupport { get; set; }
        public float TextScalingFactor { get; set; }

        public static implicit operator AccessibilityPreferenceDto?(AccessibilityPreference? v)
        {
            if (v == null)
                return null;
            return new AccessibilityPreferenceDto
            {
                EnableHighContrastMode = v.EnableHighContrastMode,
                EnableScreenReaderSupport = v.EnableScreenReaderSupport,
                TextScalingFactor = v.TextScalingFactor
            };
        }
    }
}
