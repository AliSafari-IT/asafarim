export interface IAuthResponse {
    token: string;
    user: {
      id: string;
      email: string;
      firstName: string;
      lastName: string;
      [key: string]: unknown | undefined; // Optional additional properties
    };
  }
  