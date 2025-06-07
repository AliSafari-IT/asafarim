import { IUser } from "./IUser";

export interface IAuthState {
  authenticatedUser: IUser | null;
  authenticated: boolean;
  token: string | null;
  logout: () => void;
  checkAuthState: () => void;
} 