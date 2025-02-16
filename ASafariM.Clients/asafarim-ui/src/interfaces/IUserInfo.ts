export interface IUserInfo {
  id?: string;
  fullName?: string;
  createdAt?: string;
  updatedAt?: string;
  isAdmin?: boolean;
  isDeleted?: boolean;
  deletedAt?: string;
  userId?: string;
  userName?: string;
  email?: string;
  bio?: string;
  profilePicture?: string;
  dateOfBirth?: string;
  lastLogin?: string;
  failedLoginAttempts?: number;
  isLockedOut?: boolean;
  lockoutEnd?: string;
  securityStamp?: string;
  concurrencyStamp?: string;
  phoneNumber?: string;
  phoneNumberConfirmed?: boolean;
  emailConfirmed?: boolean;
}