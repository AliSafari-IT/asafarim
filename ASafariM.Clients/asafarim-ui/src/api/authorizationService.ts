import axios from "axios";
import { IAuthorizationService } from "@/interfaces/IAuthorizationService";
import { IUserInfo } from "@/interfaces/IUserInfo";
import { apiConfig } from "../config/api";

const API_URL = apiConfig.baseURL;

class AuthorizationService implements IAuthorizationService {
  async authorizeAsync(user: IUserInfo, policyName: string): Promise<boolean> {
    try {
      console.debug("Calling authorizeAsync with:", user, policyName);

      const token = localStorage.getItem("auth")
        ? JSON.parse(localStorage.getItem("auth")!).token
        : null;

      if (!token) {
        console.warn("No token found, cannot authorize.");
        return false;
      }

      const response = await axios.post(
        `${API_URL}/auth/authorize`,
        { userId: user.id, policyName },
        {
          headers: {
            Authorization: `Bearer ${token}`,
            "Content-Type": "application/json",
          },
        }
      );

      console.debug("Authorization response:", response.data);
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
