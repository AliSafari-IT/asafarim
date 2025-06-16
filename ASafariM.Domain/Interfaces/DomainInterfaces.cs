namespace ASafariM.Domain.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; set; }
        string? Name { get; set; }
        string? FirstName { get; set; }
        string? LastName { get; set; }
    }

    public interface ITrackable
    {
        DateTime CreatedAt { get; set; }
        Guid CreatedBy { get; set; }
        DateTime? UpdatedAt { get; set; }
        Guid? UpdatedBy { get; set; }
    }

    public interface IDeletable
    {
        bool? IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }
        Guid? DeletedBy { get; set; }
    }

    public interface IHasIsActive
    {
        bool? IsActive { get; set; }
    }

    public interface IHasDateOfBirth
    {
        DateTime? DateOfBirth { get; set; }
    }

    public interface IHasLastLogin
    {
        DateTime? LastLogin { get; set; }
    }

    public interface IHasFailedLoginAttempts
    {
        int FailedLoginAttempts { get; set; }
    }

    public interface IHasIsLockedOut
    {
        bool IsLockedOut { get; set; }
    }

    public interface IHasLockoutEnd
    {
        DateTime? LockoutEnd { get; set; }
    }

    public interface IHasSecurityStamp
    {
        string? SecurityStamp { get; set; }
    }

    public interface IHasConcurrencyStamp
    {
        string? ConcurrencyStamp { get; set; }
    }

    public interface IHasPhoneNumber
    {
        string PhoneNumber { get; set; }
        bool? PhoneNumberConfirmed { get; set; }
    }
}
