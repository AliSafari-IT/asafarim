import React, { useState, useEffect, Suspense } from "react";
import { FaEnvelope, FaKey, FaTrash, FaDownload, FaUser } from "react-icons/fa";
import Wrapper from "@/layout/Wrapper/Wrapper";
import Header from "@/layout/Header/Header";
import Footer from "@/layout/Footer/Footer";
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

  // Generate user avatar initials
  const getUserInitials = () => {
    if (!authenticatedUser) return '';
    const firstInitial = authenticatedUser.firstName ? authenticatedUser.firstName.charAt(0).toUpperCase() : '';
    const lastInitial = authenticatedUser.lastName ? authenticatedUser.lastName.charAt(0).toUpperCase() : '';
    return `${firstInitial}${lastInitial}`;
  };

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
      setCurrentPassword("");
      setNewPassword("");
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
      title: "Profile Information",
      icon: <FaUser className="mr-2" />,
      content: (
        <div className="bg-white dark:bg-gray-800 rounded-lg shadow-md p-6 space-y-6">
          <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
            <InputField
              label="Email Address"
              value={email}
              placeholder="Enter your email"
              onChange={(e) => setEmail(e.target.value)}
            />
            <div className="md:col-span-2 grid grid-cols-1 md:grid-cols-2 gap-6">
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
            </div>
          </div>
          <div className="pt-4">
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
              className="px-6 py-2.5 bg-[var(--info)] hover:bg-[var(--info-dark)] text-white font-medium rounded-lg shadow-md transition-all duration-200 flex items-center"
              disabled={loading}
            >
              {loading ? (
                <>
                  <span className="mr-2 inline-block w-4 h-4 border-2 border-white border-t-transparent rounded-full animate-spin"></span>
                  Updating...
                </>
              ) : (
                "Update Profile"
              )}
            </button>
          </div>
        </div>
      ),
    },
    {
      key: "password",
      title: "Password Settings",
      icon: <FaKey className="mr-2" />,
      content: (
        <div className="bg-white dark:bg-gray-800 rounded-lg shadow-md p-6 space-y-6">
          <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
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
          </div>
          <div className="pt-4">
            <button
              onClick={handleUpdatePassword}
              className="px-6 py-2.5 bg-[var(--info)] hover:bg-[var(--info-dark)] text-white font-medium rounded-lg shadow-md transition-all duration-200 flex items-center"
              disabled={loading || !currentPassword || !newPassword}
            >
              {loading ? (
                <>
                  <span className="mr-2 inline-block w-4 h-4 border-2 border-white border-t-transparent rounded-full animate-spin"></span>
                  Updating...
                </>
              ) : (
                "Update Password"
              )}
            </button>
          </div>
        </div>
      ),
    },
    {
      key: "delete",
      title: "Delete Account",
      icon: <FaTrash className="mr-2" />,
      content: (
        <div className="bg-white dark:bg-gray-800 rounded-lg shadow-md p-6">
          <DeleteAccount currentUserInfo={authenticatedUser as IUserInfo} />
        </div>
      ),
    },
    {
      key: "export",
      title: "Export Data",
      icon: <FaDownload className="mr-2" />,
      content: (
        <div className="bg-white dark:bg-gray-800 rounded-lg shadow-md p-6">
          <ExportData currentUserInfo={authenticatedUser as IUserInfo} />
        </div>
      ),
    },
  ];

  if (loading && !authenticatedUser) {
    return (
      <Wrapper header={<Header />} footer={<Footer />}>
        <div className="flex justify-center items-center h-[70vh]">
          <div className="animate-spin rounded-full h-16 w-16 border-t-2 border-b-2 border-[var(--info)]"></div>
        </div>
      </Wrapper>
    );
  }

  if (error) {
    return (
      <Wrapper header={<Header />} footer={<Footer />}>
        <div className="flex items-center justify-center h-[70vh]">
          <div className="bg-red-100 border border-red-400 text-red-700 px-6 py-4 rounded-lg max-w-lg">
            <p className="font-medium">{error}</p>
            <button
              className="mt-4 px-4 py-2 bg-red-600 text-white rounded-md hover:bg-red-700 transition-colors"
              onClick={() => setError(null)}
            >
              Dismiss
            </button>
          </div>
        </div>
      </Wrapper>
    );
  }

  return (
    <Wrapper header={<Header />} footer={<Footer />}>
      <div className="container mx-auto px-4 py-8 max-w-5xl">
        {/* Header with user avatar */}
        <div className="bg-white dark:bg-gray-800 shadow-lg rounded-lg overflow-hidden mb-6">
          <div className="bg-gradient-to-r from-[var(--info-light)] to-[var(--info)] p-6 flex items-center">
            {authenticatedUser?.profilePicture ? (
              <img 
                src={authenticatedUser.profilePicture} 
                alt={`${authenticatedUser.firstName} ${authenticatedUser.lastName}`}
                className="w-16 h-16 rounded-full object-cover border-4 border-white shadow-md" 
              />
            ) : (
              <div className="w-16 h-16 rounded-full bg-white text-[var(--info)] flex items-center justify-center text-xl font-bold border-4 border-white shadow-md">
                {getUserInitials()}
              </div>
            )}
            <div className="ml-6 text-white">
              <h1 className="text-2xl font-bold">Account Settings</h1>
              <p className="opacity-90">Manage your preferences and security settings</p>
            </div>
          </div>
        </div>

        <Suspense fallback={<LoadingSpinner />}>
          {message && (
            <div className="mb-6">
              <Notification
                type={message.type}
                text={message.text}
                onDismiss={() => setMessage(null)}
              />
            </div>
          )}
          
          <div className="bg-white dark:bg-gray-800 shadow-lg rounded-lg overflow-hidden">
            <TabPane
              tabs={tabs}
              defaultActiveKey="email"
              onTabChange={handleTabChange}
            />
          </div>
        </Suspense>
      </div>
    </Wrapper>
  );
};

export default AccountSettings;
