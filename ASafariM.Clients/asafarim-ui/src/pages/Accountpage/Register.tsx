import React, { useState, useEffect } from "react";
import { register } from "../../api/authapi";
import { useNavigate, useLocation } from "react-router-dom";
import { IRegisterModel } from "../../interfaces/IRegisterModel";
import { logger } from "@/utils/logger";
import axios from "axios";
import { debounce } from "lodash";
import { validatePassword, getPasswordValidationMessage } from "./validatePassword";
import PasswordRequirements from "./PasswordRequirements";

import Wrapper from "../../layout/Wrapper";

const Register: React.FC = () => {
  const [model, setModel] = useState<IRegisterModel>({
    email: "",
    password: "",
    firstName: "",
    lastName: "",
    userName: "",
    isAdmin: false,
    dateOfBirth: undefined,
    profilePicture: undefined,
  });

  const [confirmPassword, setConfirmPassword] = useState("");
  const [error, setError] = useState<string | null>(null);
  const [successMessage, setSuccessMessage] = useState<string | null>(null);
  const [loading, setLoading] = useState(false);
  const [token, setToken] = useState<string | null>(null);
  const [usernameAvailable, setUsernameAvailable] = useState<boolean | null>(
    null
  );
  const [emailAvailable, setEmailAvailable] = useState<boolean | null>(null);
  const [isCheckingUsername, setIsCheckingUsername] = useState(false);
  const [isCheckingEmail, setIsCheckingEmail] = useState(false);
  const [showPasswordRequirements, setShowPasswordRequirements] = useState(false);

  const navigate = useNavigate();
  const location = useLocation();

  // For availability checks

  useEffect(() => {
    // Extract token from URL query parameters if present
    const queryParams = new URLSearchParams(location.search);
    const tokenParam = queryParams.get('token');
    const emailParam = queryParams.get('email');

    if (tokenParam) {
      setToken(tokenParam);
    }
    
    if (emailParam) {
      setModel(prev => ({ ...prev, email: emailParam }));
    }
  }, [location]);

  // Debounced check
  const checkAvailability = debounce(
    async (field: "userName" | "email", value: string) => {
      if (!value) {
        if (field === "userName") {
          setUsernameAvailable(null);
          setIsCheckingUsername(false);
        } else {
          setEmailAvailable(null);
          setIsCheckingEmail(false);
        }
        return;
      }

      try {
        if (field === "userName") {
          setIsCheckingUsername(true);
        } else {
          setIsCheckingEmail(true);
        }

        const queryParam =
          field === "userName" ? { username: value } : { email: value };
        const response = await axios.get(
          "/api/users/check-availability/validate",
          {
            params: queryParam,
          }
        );
        const { isAvailable } = response.data;

        if (field === "userName") {
          setUsernameAvailable(isAvailable);
          setIsCheckingUsername(false);
        } else {
          setEmailAvailable(isAvailable);
          setIsCheckingEmail(false);
        }
      } catch (err) {
        logger.error(`Availability check failed: ${err}`);
        if (field === "userName") {
          setIsCheckingUsername(false);
        } else {
          setIsCheckingEmail(false);
        }
      }
    },
    750
  );

  const handleInputChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;

    if (name === "confirmPassword") {
      setConfirmPassword(value);
      return;
    }

    if (name === "dateOfBirth") {
      setModel((prev) => ({
        ...prev,
        dateOfBirth: value ? new Date(value) : undefined,
      }));
    } else {
      setModel((prev) => ({
        ...prev,
        [name]: value,
      }));
    }

    // If user changes username or email, do the availability check
    if (name === "userName") {
      checkAvailability("userName", value);
    } else if (name === "email") {
      checkAvailability("email", value);
    }
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setError(null);
    setSuccessMessage(null);

    try {
      logger.info("Registration started");

      // Check if token is required for certain operations
      if (location.search.includes('token') && !token) {
        setError('Invalid reset link. Please request a new password reset.');
        return;
      }

      // Basic validation
      if (
        !model.email ||
        !model.password ||
        !model.firstName ||
        !model.lastName ||
        !model.userName
      ) {
        setError("All fields are required");
        return;
      }

      // Password validation
      if (model.password !== confirmPassword) {
        setError("Passwords do not match");
        return;
      }

      const passwordValidation = validatePassword(model.password);
      if (!passwordValidation.isValid) {
        setError(getPasswordValidationMessage(passwordValidation));
        return;
      }

      const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
      if (!emailRegex.test(model.email)) {
        setError("Please enter a valid email address");
        return;
      }

      if (model.userName.length < 3) {
        setError("Username must be at least 3 characters long");
        return;
      }

      // Check if username and email are available before submitting
      if (usernameAvailable === false) {
        setError("Username is already taken. Please choose another one.");
        return;
      }

      if (emailAvailable === false) {
        setError('Email is already registered. Please use another email or sign in.');
        return;
      }

      const registrationData = {
        ...model,
        dateOfBirth: model.dateOfBirth
          ? new Date(model.dateOfBirth)
          : undefined,
        isAdmin: false,
      };

      setLoading(true);
      logger.info(
        `Calling register API with model: ${JSON.stringify(registrationData)}`
      );
      const response = await register(registrationData);

      logger.info("Register API call completed", response);
      setSuccessMessage("Registration successful!");
      setTimeout(() => {
        navigate("/login");
      }, 2000);
    } catch (err: any) {
      logger.error("Registration error:", err);

      if (err?.response?.data?.message) {
        setError(err.response.data.message);
      } else if (err instanceof Error) {
        setError(err.message);
      } else {
        setError("An unexpected error occurred during registration.");
      }
    } finally {
      setLoading(false);
    }
  };

  return (
    <Wrapper
      header={
        <div className="w-full text-center py-8 text-2xl text-primary border-b border-primary z-10">
          Register
        </div>
      }
    >
      <div className="flex items-center justify-center min-h-[calc(100vh-var(--navbar-height)-200px)]">
        <form
          onSubmit={handleSubmit}
          className="login-form flex flex-col items-center justify-center space-y-6 w-full max-w-md mx-auto px-4 py-8 bg-white dark:bg-gray-800 shadow-md rounded-lg"
          role="form"
          data-testid="register-form"
        >
          {/* Input fields */}
          {[
            ["First Name", "firstName"],
            ["Last Name", "lastName"],
            ["Username", "userName"],
            ["Email", "email"],
          ].map(([label, field]) => (
            <div className="w-full" key={field}>
              <label
                htmlFor={field}
                className="block mb-2 font-semibold text-gray-700 dark:text-gray-300"
              >
                {label}:
              </label>
              <input
                type={
                  field === "email"
                    ? "email"
                    : "text"
                }
                id={field}
                name={field}
                value={(model as any)[field]}
                onChange={handleInputChange}
                placeholder={`Enter your ${label.toLowerCase()}`}
                required
                className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
                data-testid={`${field}-input`}
              />
              {/* Feedback messages for username and email */}
              {field === "userName" && (
                <>
                  {isCheckingUsername && (
                    <p className="text-sm mt-1 text-gray-500">
                      Checking username availability...
                    </p>
                  )}
                  {!isCheckingUsername && usernameAvailable !== null && (
                    <p
                      className={`text-sm mt-1 ${
                        usernameAvailable ? "text-green-500" : "text-red-500"
                      }`}
                      data-testid="username-availability"
                    >
                      {usernameAvailable
                        ? "Username is available"
                        : "Username is already taken"}
                    </p>
                  )}
                </>
              )}
              {field === "email" && (
                <>
                  {isCheckingEmail && (
                    <p className="text-sm mt-1 text-gray-500">
                      Checking email availability...
                    </p>
                  )}
                  {!isCheckingEmail && emailAvailable !== null && (
                    <p
                      className={`text-sm mt-1 ${
                        emailAvailable ? "text-green-500" : "text-red-500"
                      }`}
                      data-testid="email-availability"
                    >
                      {emailAvailable
                        ? "Email is available"
                        : "Email is already registered"}
                    </p>
                  )}
                </>
              )}
            </div>
          ))}

          {/* Password */}
          <div className="w-full">
            <label
              htmlFor="password"
              className="block mb-2 font-semibold text-gray-700 dark:text-gray-300"
            >
              Password:
            </label>
            <input
              type="password"
              id="password"
              name="password"
              value={model.password}
              onChange={handleInputChange}
              placeholder="Enter your password"
              required
              className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
              data-testid="password-input"
              onFocus={() => setShowPasswordRequirements(true)}
            />
          </div>

          {showPasswordRequirements && (
            <PasswordRequirements password={model.password} />
          )}

          {/* Confirm Password */}
          <div className="w-full">
            <label
              htmlFor="confirmPassword"
              className="block mb-2 font-semibold text-gray-700 dark:text-gray-300"
            >
              Confirm Password:
            </label>
            <input
              type="password"
              id="confirmPassword"
              name="confirmPassword"
              value={confirmPassword}
              onChange={handleInputChange}
              placeholder="Confirm your password"
              required
              className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
              data-testid="confirm-password-input"
            />
          </div>

          {/* Date of Birth */}
          <div className="w-full">
            <label
              htmlFor="dateOfBirth"
              className="block mb-2 font-semibold text-gray-700 dark:text-gray-300"
            >
              Date of Birth:
            </label>
            <input
              type="date"
              id="dateOfBirth"
              name="dateOfBirth"
              value={
                model.dateOfBirth
                  ? model.dateOfBirth.toISOString().split("T")[0]
                  : ""
              }
              onChange={handleInputChange}
              className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
              data-testid="dateOfBirth-input"
            />
          </div>

          {/* Profile Picture */}
          <div className="w-full">
            <label
              htmlFor="profilePicture"
              className="block mb-2 font-semibold text-gray-700 dark:text-gray-300"
            >
              Profile Picture URL:
            </label>
            <input
              type="text"
              id="profilePicture"
              name="profilePicture"
              value={model.profilePicture || ""}
              onChange={handleInputChange}
              placeholder="Enter a profile picture URL"
              className="w-full px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
              data-testid="profilePicture-input"
            />
          </div>

          {/* Error Message */}
          {error && (
            <div
              className="w-full text-red-500 text-center"
              data-testid="error-message"
              role="alert"
              aria-live="assertive"
            >
              {error}
            </div>
          )}

          {/* Success Message */}
          {successMessage && (
            <div
              className="w-full text-green-500 text-center"
              data-testid="success-message"
              role="alert"
              aria-live="assertive"
            >
              {successMessage}
            </div>
          )}

          {/* Submit Button */}
          <button
            type="submit"
            disabled={loading}
            className="w-full py-3 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors disabled:opacity-50"
            data-testid="register-button"
          >
            {loading ? "Registering..." : "Register"}
          </button>

          {/* Login Redirect */}
          <div className="w-full text-center">
            <p className="text-gray-600 dark:text-gray-400">
              Already have an account?{" "}
              <a
                href="/login"
                onClick={(e) => {
                  e.preventDefault();
                  navigate("/login");
                }}
                className="text-blue-600 hover:text-blue-800 dark:text-blue-400 dark:hover:text-blue-300 font-semibold"
                data-testid="login-link"
              >
                Sign in
              </a>
            </p>
          </div>
        </form>
      </div>
    </Wrapper>
  );
};

export default Register;
