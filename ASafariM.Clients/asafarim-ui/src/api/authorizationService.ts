import axios from "axios";
import { IAuthorizationService } from "@/interfaces/IAuthorizationService";
import { IUserInfo } from "@/interfaces/IUserInfo";
import { apiConfig } from "../config/api";
import { jwtDecode } from "jwt-decode";

const API_URL = apiConfig.baseURL;
const authorizeUrl = `${API_URL}/auth/authorize`;

interface JwtPayload {
  nameid?: string;
  role?: string;
  exp?: number;
}

class AuthorizationService implements IAuthorizationService {

  async authorizeAsync(user: IUserInfo, policyName: string): Promise<boolean> {
    try {
      // Check both localStorage and sessionStorage for auth data
      let authData = localStorage.getItem('auth') || sessionStorage.getItem('auth');
      
      if (!authData) {
        console.warn('No auth data found in storage');
        return false;
      }
      
      const parsedAuth = JSON.parse(authData);
      const token = parsedAuth.token;
      
      if (!token) {
        console.warn('No token found in auth data');
        return false;
      }
      
      // For update_profile policy, allow if user is authenticated
      if (policyName === 'update_profile' && parsedAuth.authenticated) {
        return true;
      }
      
      // Make API call for other policies
      const response = await axios.post(
        authorizeUrl,
        { userId: user.id, policyName },
        {
          headers: {
            Authorization: `Bearer ${token}`,
            'Content-Type': 'application/json'
          }
        }
      );
      
      return response.data.isAuthorized;
    } catch (error) {
      console.error('Authorization failed:', error);
      return false;
    }
  }

  authorize(user: IUserInfo, policyName: string): boolean {
    if (!user || !policyName) {
      return false;
    }

    if (policyName === "admin_only") {
      return user.isAdmin;
    }

    if (policyName === "update_profile") {
      // Allow users to update their own profile
      return true; // All authenticated users should be able to update their own profile
    }

    if (policyName === "delete_user") {
      return user.isAdmin;
    }

    return false;
  }
}

export default new AuthorizationService();
