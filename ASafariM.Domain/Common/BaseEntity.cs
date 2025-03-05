using System;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public string CreatedBy { get; set; } = "System";
        public string? UpdatedBy { get; set; }
        public string? DeletedBy { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public string? DeletedMessage { get; set; } = null;
    }
}
