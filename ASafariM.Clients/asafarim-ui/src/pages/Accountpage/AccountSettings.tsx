import React, { useState, useEffect, Suspense } from "react";
import { FaEnvelope, FaKey } from "react-icons/fa";
import Layout from "@/layout/Layout";
import useAuth from "@/hooks/useAuth";
import DeleteAccount from "../User/DeleteAccount";
import ExportData from "../User/ExportData";
import { useNavigate } from "react-router-dom";
import { updatePassword } from "@/api/authService";
import LoadingSpinner from "@/components/Loading/LoadingSpinner";
import TabPane from "@/components/Containers/Tab/TabPane";
import InputField from "@/components/InputField/InputField";
import Notification from "@/components/Notification/Notification";
import { IUserInfo } from "@/interfaces";
import handleUpdateProfile from "./handleUpdateProfile";

const AccountSettings: React.FC = () => {
  const [email, setEmail] = useState("");
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [newPassword, setNewPassword] = useState("");
  const [currentPassword, setCurrentPassword] = useState("");
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [message, setMessage] = useState<{ type: string; text: string } | null>(
    null
  );
  const navigate = useNavigate();
  const { authenticatedUser, authenticated } = useAuth();

  useEffect(() => {
    const loadUserData = async () => {
      try {
        setLoading(true);
        setError(null);
        if (!authenticated || !authenticatedUser) {
          navigate("/login");
          return;
        }

        setEmail(authenticatedUser.email);
        setFirstName(authenticatedUser.firstName);
        setLastName(authenticatedUser.lastName);
        setLoading(false);
      } catch (err) {
        console.error("Error loading user data:", err);
        setError(
          "Failed to load user information. Please try refreshing the page."
        );
        setLoading(false);
      }
    };

    loadUserData();
  }, [authenticated, authenticatedUser, navigate]);

  // async function handleUpdateProfile(): Promise<void> {
  //     console.debug('authenticatedUser:', authenticatedUser);

  //     if (!/\S+@\S+\.\S+/.test(email)) {
  //         setMessage({ type: 'error', text: 'Please enter a valid email address.' });
  //         return;
  //     }

  //     try {
  //         const updatedUser = { ...authenticatedUser, email, firstName, lastName };
  //         console.debug("updatedUser:", updatedUser);
  //         await updateUser(updatedUser);
  //         setMessage({ type: 'success', text: 'Profile updated successfully!' });

  //         // Wait for 2 seconds before showing the warning
  //         await new Promise(resolve => setTimeout(resolve, 2000));

  //         // Show warning about re-login
  //         setMessage({ type: 'warning', text: 'We will now re-login to let the updated details take effect.' });

  //         // Wait for another 2 seconds before removing auth and redirecting
  //         await new Promise(resolve => setTimeout(resolve, 3000));

  //         localStorage.removeItem('auth');
  //         window.dispatchEvent(new Event('authStateChange'));
  //     } catch (err) {
  //         console.error('Error updating profile:', err);
  //         setMessage({ type: 'error', text: 'Failed to update profile.' });
  //     } finally {
  //         setLoading(false);
  //     }
  // }

  const handleUpdatePassword = async () => {
    console.log(
      "Updating password...",
      authenticatedUser,
      currentPassword,
      newPassword
    );
    setLoading(true);
    try {
      await updatePassword({
        Id: authenticatedUser!.id,
        currentPassword: currentPassword,
        newPassword: newPassword,
      });

      // Optionally update local storage
      const auth = JSON.parse(localStorage.getItem("auth") || "{}");
      auth.passwordUpdated = true; // Example flag
      localStorage.setItem("auth", JSON.stringify(auth));
      // Trigger auth state change
      window.dispatchEvent(new Event("authStateChange"));
      setMessage({ type: "success", text: "Password updated successfully." });
    } catch (err) {
      console.error("Error updating password:", err);
      setMessage({ type: "error", text: "Failed to update password." });
    } finally {
      setLoading(false);
    }
  };

  const handleTabChange = (key: string) => {
    console.log("Tab changed to:", key);
  };

  const tabs = [
    {
      key: "email",
      title: "Email Settings",
      icon: <FaEnvelope />,
      content: (
        <div className="space-y-6">
          <InputField
            label="Email Address"
            value={email}
            placeholder="Enter your email"
            onChange={(e) => setEmail(e.target.value)}
          />
          <InputField
            label="First Name"
            value={firstName}
            placeholder="Enter your first name"
            onChange={(e) => setFirstName(e.target.value)}
          />
          <InputField
            label="Last Name"
            value={lastName}
            placeholder="Enter your last name"
            onChange={(e) => setLastName(e.target.value)}
          />
          <button
            onClick={() =>
              handleUpdateProfile({
                authenticatedUser,
                firstName,
                lastName,
                email,
                setMessage,
                setLoading,
              })
            }
            className="w-full sm:w-auto bg-info text-white px-4 py-2 rounded-md"
            disabled={loading}
          >
            {loading ? "Updating..." : "Update Profile"}
          </button>
        </div>
      ),
    },
    {
      key: "password",
      title: "Password Settings",
      icon: <FaKey />,
      content: (
        <div className="space-y-6">
          <InputField
            label="Current Password"
            type="password"
            value={currentPassword}
            placeholder="Enter current password"
            onChange={(e) => setCurrentPassword(e.target.value)}
          />
          <InputField
            label="New Password"
            type="password"
            value={newPassword}
            placeholder="Enter new password"
            onChange={(e) => setNewPassword(e.target.value)}
          />
          <button
            onClick={handleUpdatePassword}
            className="w-full sm:w-auto bg-info text-white px-4 py-2 rounded-md"
            disabled={loading}
          >
            {loading ? "Updating..." : "Update Password"}
          </button>
        </div>
      ),
    },
    {
      key: "delete",
      title: "Delete Account",
      icon: null,
      content: (
        <DeleteAccount currentUserInfo={authenticatedUser as IUserInfo} />
      ),
    },
    {
      key: "export",
      title: "Export Data",
      icon: null,
      content: <ExportData currentUserInfo={authenticatedUser as IUserInfo} />,
    },
  ];

  if (loading) {
    return <div className="text-center p-4">Loading...</div>;
  }

  if (error) {
    return (
      <div
        className="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded relative"
        role="alert"
      >
        <span className="block sm:inline">{error}</span>
        <button
          className="absolute top-0 bottom-0 right-0 px-4 py-3"
          onClick={() => setError(null)}
        >
          <span className="sr-only">Dismiss</span>
          <svg
            className="h-6 w-6 text-red-500"
            role="button"
            xmlns="http://www.w3.org/2000/svg"
            viewBox="0 0 20 20"
          >
            <title>Close</title>
            <path d="M14.348 14.849a1.2 1.2 0 0 1-1.697 0L10 11.819l-2.651 3.029a1.2 1.2 0 1 1-1.697-1.697l2.758-3.15-2.759-3.152a1.2 1.2 0 1 1 1.697-1.697L10 8.183l2.651-3.031a1.2 1.2 0 1 1 1.697 1.697l-2.758 3.152 2.758 3.15a1.2 1.2 0 0 1 0 1.698z" />
          </svg>
        </button>
      </div>
    );
  }

  return (
    <Layout
      header={
        <div className="bg-info/5 p-6 text-center">
          <h1 className="text-2xl font-bold text-gray-800 dark:text-gray-100">
            Account Settings
          </h1>
          <p className="text-gray-600 dark:text-gray-400">
            Manage your preferences and security settings
          </p>
        </div>
      }
    >
      <div className="max-w-4xl mx-auto px-4 py-8">
        <Suspense fallback={<LoadingSpinner />}>
          {message && (
            <Notification
              type={message.type}
              text={message.text}
              onClose={() => setMessage(null)}
            />
          )}
          <TabPane
            tabs={tabs}
            defaultActiveKey="email"
            onTabChange={handleTabChange}
          />
        </Suspense>
      </div>
    </Layout>
  );
};

export default AccountSettings;
