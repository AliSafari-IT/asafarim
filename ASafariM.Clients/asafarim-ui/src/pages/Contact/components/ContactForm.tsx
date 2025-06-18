import { useEffect, useRef, useState } from "react";
import emailjs from "@emailjs/browser";
import { useAuth } from "@/contexts/AuthContext";
import ContactPageLayout from "./ContactPageLayout";
import { logger } from "@/utils/logger";
import React from "react";

const SERVICE_ID = import.meta.env.VITE_EMAILJS_SERVICE_ID;
const TEMPLATE_ID = import.meta.env.VITE_EMAILJS_TEMPLATE_ID;
const PUBLIC_KEY = import.meta.env.VITE_EMAILJS_PUBLIC_KEY;

export const ContactForm = () => {
  const { authenticatedUser } = useAuth();
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [message, setMessage] = useState("");
  const [errorMessage, setErrorMessage] = useState("");
  const form = useRef<HTMLFormElement | null>(null); // Initialize to null

  useEffect(() => {
    if (authenticatedUser) {
      setName(authenticatedUser.userName || "");
      setEmail(authenticatedUser.email || "");
    }
    if (!authenticatedUser) {
      setName("");
      setEmail("");
    }
  }, [authenticatedUser]);

  // Utility function to validate email
  const validateEmail = (email: string) => {
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
  };

  const sendEmail = (e: { preventDefault: () => void }) => {
    e.preventDefault();

    if (!message) {
      setErrorMessage("Please fill in all fields.");
      return;
    }

    if (!validateEmail(email)) {
      setErrorMessage("Please enter a valid email address.");
      return;
    }

    setErrorMessage("");

    // Create template parameters
    const templateParams = {
      from_name: name,
      from_email: email,
      message: message,
      to_name: "ASafariM Team",
    };
    logger.debug("Sending email with template params:", templateParams);

    if (form.current) {
      emailjs
        .sendForm(SERVICE_ID, TEMPLATE_ID, form.current, {
          publicKey: PUBLIC_KEY,
        })
        .then(
          () => {
            alert("Message Sent, We will get back to you shortly!");
            logger.info("Email sent successfully...");
            setMessage("");
          },
          (error) => {
            logger.error("Email send failed...", error.text);
            alert("An error occurred, Please try again.");
          }
        );
    } else {
      logger.error("Form is not defined");
      alert("Form is not available. Please try again.");
    }
  };

  return (
    <ContactPageLayout>
      <div className="w-full max-w-lg px-4">
        {errorMessage && (
          <div className="text-sm text-red-600 dark:text-red-400 text-center mb-4">
            {errorMessage}
          </div>
        )}

        <div className="bg-white dark:bg-gray-800 shadow-sm rounded-lg p-6">
          <div className="text-center mb-8">
            <h1 className="text-3xl font-semibold text-gray-800 dark:text-white mb-2">
              Contact Us
            </h1>
          </div>
          <form ref={form} onSubmit={sendEmail} className="space-y-4">
            <div>
              <label className="block text-sm text-gray-600 dark:text-gray-400 mb-1">
                Name
              </label>
              <input
                className="w-full p-2 bg-gray-50 dark:bg-gray-900 border border-gray-200 dark:border-gray-700 rounded-md
                           text-gray-800 dark:text-gray-200 placeholder-gray-400
                           focus:outline-none focus:border-blue-500 dark:focus:border-blue-400"
                type="text"
                name="from_name"
                value={name}
                onChange={(e) => setName(e.target.value)}
                disabled={authenticatedUser ? true : false}
              />
            </div>

            <div>
              <label className="block text-sm text-gray-600 dark:text-gray-400 mb-1">
                Email
              </label>
              <input
                className="w-full p-2 bg-gray-50 dark:bg-gray-900 border border-gray-200 dark:border-gray-700 rounded-md
                           text-gray-800 dark:text-gray-200 placeholder-gray-400
                           focus:outline-none focus:border-blue-500 dark:focus:border-blue-400"
                type="email"
                name="from_email"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
                disabled={authenticatedUser ? true : false}
              />
            </div>

            <div>
              <label className="block text-sm text-gray-600 dark:text-gray-400 mb-1">
                Message
              </label>
              <textarea
                className="w-full p-2 bg-gray-50 dark:bg-gray-900 border border-gray-200 dark:border-gray-700 rounded-md
                           text-gray-800 dark:text-gray-200 placeholder-gray-400
                           focus:outline-none focus:border-blue-500 dark:focus:border-blue-400
                           h-32 resize-none"
                name="message"
                value={message}
                onChange={(e) => setMessage(e.target.value)}
                placeholder="Type your message here"
                required
              />
            </div>

            <div className="mt-6">
              <button
                type="submit"
                className="w-full bg-blue-500 text-white py-2 px-4 rounded-md hover:bg-blue-600 
                           transition-colors duration-200 focus:outline-none"
              >
                Send Message
              </button>
            </div>
          </form>
        </div>
      </div>
    </ContactPageLayout>
  );
};

export default ContactForm;
