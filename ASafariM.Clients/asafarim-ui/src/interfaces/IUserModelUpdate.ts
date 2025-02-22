export interface IUserModelUpdate {
    id: string; // Guid
    firstName: string;
    lastName: string;
    email?: string;
    isAdmin?: boolean;
    userName?: string;
    address?: string;
    bio?: string;
    remark?: string;
    profilePicture?: string;
    dateOfBirth?: string;
    isActive?: boolean;
    createdBy?: string;
    updatedBy?: string;
    deletedBy?: string;
    isLockedOut?: boolean;
    lockoutEnd?: string;
    securityStamp?: string;
    concurrencyStamp?: string;
    phoneNumber?: string;
    phoneNumberConfirmed?: boolean;
    emailConfirmed?: boolean;
    password?: string;
    roles?: string[]; // Array of role IDs
}
