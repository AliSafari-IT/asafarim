import { getUserProfile, updateUserProfile } from "@/api/authapi";
import { IUserModelUpdate } from "@/interfaces";
import { IUserInfo } from "@/interfaces/IUserInfo";

const handleUpdateProfile = async (
  authenticatedUser: IUserInfo,
  email: string,
  firstName: string,
  lastName: string,
  setMessage: (message: { type: string; text: string }) => void,
  setLoading: (loading: boolean) => void
) => {
  console.debug("authenticatedUser:", authenticatedUser);

  if (!/\S+@\S+\.\S+/.test(email)) {
    setMessage({ type: "error", text: "Please enter a valid email address." });
    return;
  }

  try {
    const updatedUser = {
      id: authenticatedUser.id,
      firstName,
      lastName,
      email,
    } as IUserModelUpdate;

    await updateUserProfile(updatedUser); // Use new function
    setMessage({ type: "success", text: "Profile updated successfully! Refreshing..." });
    // Force a refresh of the user data
    const userProfile = await getUserProfile(authenticatedUser.id); // Fetch updated user profile
    localStorage.setItem(
      "auth",
      JSON.stringify({ ...authenticatedUser, user: userProfile })
    ); // Update local storage with new profile

    // pause for 1 second before updating the auth state
    await new Promise((resolve) => setTimeout(resolve, 2000));
    window.dispatchEvent(new Event("authStateChange"));
  } catch (err) {
    console.error("Error updating profile:", err);
    setMessage({ type: "error", text: "Failed to update profile." });
  } finally {
    setLoading(false);
  }
};

//const delay = (ms: number) => new Promise(resolve => setTimeout(resolve, ms));

export default handleUpdateProfile;
