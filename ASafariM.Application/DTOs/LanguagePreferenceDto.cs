using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;

namespace ASafariM.Application.DTOs
{
    public class LanguagePreferenceDto
    {
        public LanguageEnum Language { get; set; } = LanguageEnum.en_US;

        public static implicit operator LanguagePreferenceDto?(LanguagePreference? v)
        {
            if (v == null)
                return null;
            return new LanguagePreferenceDto { Language = v.Language };
        }
    }
}
