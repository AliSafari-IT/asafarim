import { updateUserProfile } from "@/api/authapi";
import { IUserInfo } from "@/interfaces/IUserInfo";

interface HandleUpdateProfileProps {
  authenticatedUser: IUserInfo;
  firstName: string;
  lastName: string;
  email: string;
  setMessage: (message: { type: string; text: string }) => void;
  setLoading: (loading: boolean) => void;
}

const handleUpdateProfile = async (
  data: HandleUpdateProfileProps
) => {
  const { authenticatedUser, firstName, lastName, email, setMessage, setLoading } = data;
  console.info("handleUpdateProfile: ", {
    authenticatedUser,
    firstName,
    lastName,
    email,
  });

  // Ensure user object is correctly formatted
  if (!authenticatedUser || !authenticatedUser.id) {
    setMessage({ type: "error", text: "Invalid user data." });
    return;
  }

  try {
    setLoading(true);

    // Get current stored auth data
    const storedAuthData = localStorage.getItem('auth') || sessionStorage.getItem('auth');
    if (!storedAuthData) {
      setMessage({ type: "error", text: "Authentication data not found. Please log in again." });
      return;
    }

    // Skip authorization check for self-update
    // This operation is always allowed for the authenticated user

    if (email !== authenticatedUser.email && !/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/.test(email)) {
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
      text: "Profile updated successfully! Redirecting...",
    });

    // Parse stored auth data
    const parsedAuthData = JSON.parse(storedAuthData);
    
    // Update the stored auth data with new profile information
    const updatedAuthData = {
      ...parsedAuthData,
      authenticatedUser: {
        ...parsedAuthData.authenticatedUser,
        firstName,
        lastName, 
        email
      }
    };
    
    // Save updated auth data
    localStorage.setItem('auth', JSON.stringify(updatedAuthData));
    
    // Redirect to profile page after 1 second
    setTimeout(() => {
      window.location.href = '/user-profile';
    }, 1000);
    
  } catch (err) {
    console.error("Error updating profile:", err);
    setMessage({ type: "error", text: "Failed to update profile." });
  } finally {
    setLoading(false);
  }
};

export default handleUpdateProfile;
