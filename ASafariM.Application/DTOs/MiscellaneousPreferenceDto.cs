using ASafariM.Domain.Entities;

namespace ASafariM.Application.DTOs
{
    public class MiscellaneousPreferenceDto
    {
        public string? PreferredFileFormat { get; set; }
        public int ItemsPerPage { get; set; }
        public bool EnableAutoSave { get; set; }
        public bool EnableRealTimeUpdates { get; set; }
        public string? DefaultDashboardView { get; set; }
        public bool ShowActivityTimeline { get; set; }

        public static implicit operator MiscellaneousPreferenceDto?(MiscellaneousPreference? v)
        {
            if (v == null)
                return null;
            return new MiscellaneousPreferenceDto
            {
                PreferredFileFormat = v.FileFormat?.Name,
                ItemsPerPage = v.PaginationSettings.ItemsPerPage,
                EnableAutoSave = v.EnableAutoSave,
                EnableRealTimeUpdates = v.EnableRealTimeUpdates,
                DefaultDashboardView = v.DefaultDashboardView,
                ShowActivityTimeline = v.ShowActivityTimeline,
            };
        }
    }
}
