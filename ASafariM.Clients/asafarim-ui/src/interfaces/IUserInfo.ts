export interface IUserInfo {
  id?: string;
  fullName?: string;
  isAdmin: boolean;
  firstName?: string;
  lastName?: string;
  createdAt?: string;
  updatedAt?: string;
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
  roles?: string[];
  isLoggedIn?: boolean;
}