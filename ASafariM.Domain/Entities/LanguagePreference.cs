using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Enums;

namespace ASafariM.Domain.Entities
{
    public class LanguagePreference
    {
        [Key]
        public Guid Id { get; set; }

        public LanguageEnum Language { get; set; } = LanguageEnum.en_US;
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}