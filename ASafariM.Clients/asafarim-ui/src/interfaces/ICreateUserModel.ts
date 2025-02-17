export interface ICreateUserModel {
  firstName: string;
  lastName: string;
  email: string;
  userName: string;
  password: string;
  dateOfBirth?: string;
  profilePicture?: string;
  isAdmin: boolean;
}
