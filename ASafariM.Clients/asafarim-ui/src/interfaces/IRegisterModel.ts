export interface IRegisterModel {
  email: string; // Required email with valid format
  password: string; // Required password with minimum length
  firstName: string; // Required first name with minimum length
  lastName: string; // Required last name with minimum length
  userName: string; // Required username with minimum length 3
  dateOfBirth?: Date; // Optional date of birth
  profilePicture?: string; // Optional profile picture URL
  isAdmin?: boolean; // Optional admin flag
  isUser?: boolean;
  biography?: string;
  isActive?: boolean;
  createdAt?: Date;
  lastLogin?: Date;
  updatedAt?: Date;
  
}