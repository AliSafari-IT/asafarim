import { getUserProfile, updateUserProfile } from "@/api/authapi";
import { IUserInfo } from "@/interfaces/IUserInfo";
import authorizationService from "@/api/authorizationService";

const handleUpdateProfile = async (
  authenticatedUser: IUserInfo,
  firstName: string,
  lastName: string,
  email: string,
  setMessage: (message: { type: string; text: string }) => void,
  setLoading: (loading: boolean) => void
) => {
  console.debug("Authenticated User:", authenticatedUser);

  // Ensure user object is correctly formatted
  if (!authenticatedUser || !authenticatedUser.id) {
    setMessage({ type: "error", text: "Invalid user data." });
    return;
  }

  try {
    setLoading(true);

    // Ensure authorization works
    const isAuthorized = await authorizationService.authorizeAsync(
      authenticatedUser,
      "update_profile"
    );

    console.debug("Authorization check result:", isAuthorized);

    if (!isAuthorized) {
      setMessage({
        type: "error",
        text: "You are not authorized to update your profile.",
      });
      return;
    }

    if (!/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/.test(email)) {
      setMessage({ type: "error", text: "Please enter a valid email address: " + email });
      return;
    }

    const updatedUser = {
      id: authenticatedUser.id,
      firstName,
      lastName,
      email,
    };

    await updateUserProfile(updatedUser);
    setMessage({
      type: "success",
      text: "Profile updated successfully! Refreshing...",
    });

    // Refresh user data
    const userProfile = await getUserProfile(authenticatedUser.id);
    localStorage.setItem(
      "auth",
      JSON.stringify({ ...authenticatedUser, user: userProfile })
    );

    await new Promise((resolve) => setTimeout(resolve, 2000));
    window.dispatchEvent(new Event("authStateChange"));
  } catch (err) {
    console.error("Error updating profile:", err);
    setMessage({ type: "error", text: "Failed to update profile." });
  } finally {
    setLoading(false);
  }
};

export default handleUpdateProfile;
