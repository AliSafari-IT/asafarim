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
      // Get fresh token from localStorage each time
      const authData = localStorage.getItem("auth");
      const token = authData ? JSON.parse(authData).token : null;
      
      console.info("Calling authorizeAsync with:", user, policyName);
      console.info("Token available:", !!token);
      
      if (!token) {
        console.warn("No token found, cannot authorize.");
        return false;
      }
      if (!user.id) {
        console.warn("User ID is missing, cannot authorize.");
        return false;
      }
      if (!policyName) {
        console.warn("Policy name is missing, cannot authorize.");
        return false;
      }

      const decodedToken = jwtDecode<JwtPayload>(token);
      console.info("Decoded Token:", decodedToken);
      
      const response = await axios.post(
        authorizeUrl,
        { userId: user.id, policyName },
        {
          headers: {
            Authorization: `Bearer ${token}`,
            "Content-Type": "application/json",
          },
        }
      );

      console.info("Authorization response:", response);
      return response.data.isAuthorized;
    } catch (error) {
      console.error("Authorization failed:", error);
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
      return !!user.email && !!user.firstName && !!user.lastName;
    }

    if (policyName === "delete_user") {
      return user.isAdmin;
    }

    return false;
  }
}

export default new AuthorizationService();
