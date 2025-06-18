import React from "react";

export const ContactInfo = () => {
  return (
    <div className="flex flex-col gap-8">
      {/* Connect Card */}
      <div className="bg-white dark:bg-gray-800 rounded-xl shadow-lg p-8">
        <div className="flex items-center mb-6">
          <div className="w-12 h-12 bg-teal-100 dark:bg-teal-900 rounded-full flex items-center justify-center mr-4">
            <svg
              xmlns="http://www.w3.org/2000/svg"
              className="h-6 w-6 text-teal-600 dark:text-teal-400"
              fill="none"
              viewBox="0 0 24 24"
              stroke="currentColor"
            >
              <path
                strokeLinecap="round"
                strokeLinejoin="round"
                strokeWidth={2}
                d="M3 8l7.89 5.26a2 2 0 002.22 0L21 8M5 19h14a2 2 0 002-2V7a2 2 0 00-2-2H5a2 2 0 00-2 2v10a2 2 0 002 2z"
              />
            </svg>
          </div>
          <h2 className="text-2xl font-bold text-gray-800 dark:text-white">
            Connect With Me
          </h2>
        </div>

        {/* Responsive grid layout that adapts to screen size */}
        <div className="grid grid-cols-1 sm:grid-cols-2 gap-8 sm:gap-6 relative">
          {/* Optional connecting lines for visual effect - only visible on larger screens */}
          <div className="hidden sm:block absolute top-1/2 left-0 right-0 h-[1px] bg-gray-200 dark:bg-gray-700 z-0"></div>
          <div className="hidden sm:block absolute top-0 bottom-0 left-1/2 w-[1px] bg-gray-200 dark:bg-gray-700 z-0"></div>
          
          {/* Center element - only visible on larger screens */}
          <div className="hidden sm:flex absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 z-10">
            <div className="w-16 h-16 rounded-full bg-gradient-to-r from-teal-400 to-blue-500 flex items-center justify-center shadow-lg">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                className="h-8 w-8 text-white"
                fill="none"
                viewBox="0 0 24 24"
                stroke="currentColor"
              >
                <path
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  strokeWidth={2}
                  d="M17 8h2a2 2 0 012 2v6a2 2 0 01-2 2h-2v4l-4-4H9a1.994 1.994 0 01-1.414-.586m0 0L11 14h4a2 2 0 002-2V6a2 2 0 00-2-2H5a2 2 0 00-2 2v6a2 2 0 002 2h2v4l.586-.586z"
                />
              </svg>
            </div>
          </div>

          {/* Email Contact */}
          <div className="flex flex-col items-center p-4 sm:p-0">
            <div className="w-12 h-12 rounded-full bg-gradient-to-r from-red-500 to-yellow-500 flex items-center justify-center shadow-md mb-3">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                className="h-6 w-6 text-white"
                viewBox="0 0 20 20"
                fill="currentColor"
              >
                <path d="M2.003 5.884L10 9.882l7.997-3.998A2 2 0 0016 4H4a2 2 0 00-1.997 1.884z" />
                <path d="M18 8.118l-8 4-8-4V14a2 2 0 002 2h12a2 2 0 002-2V8.118z" />
              </svg>
            </div>
            <p className="font-medium text-gray-700 dark:text-gray-300 mb-1 text-center">
              Email
            </p>
            <a
              href="mailto:asafarim@gmail.com"
              className="group inline-flex items-center"
            >
              <span className="text-teal-600 dark:text-teal-400 font-medium group-hover:text-yellow-600 dark:group-hover:text-yellow-400 transition-colors duration-300 hover:underline">
              asafarim[@]gmail.com
              </span>
              <span className="ml-2 opacity-0 group-hover:opacity-100 transition-opacity duration-300">
                <svg 
                  xmlns="http://www.w3.org/2000/svg" 
                  className="h-4 w-4 text-yellow-500" 
                  viewBox="0 0 20 20" 
                  fill="currentColor"
                >
                  <path fillRule="evenodd" d="M7.293 14.707a1 1 0 010-1.414L10.586 10 7.293 6.707a1 1 0 011.414-1.414l4 4a1 1 0 010 1.414l-4 4a1 1 0 01-1.414 0z" clipRule="evenodd" />
                </svg>
              </span>
            </a>
          </div>

          {/* GitHub Contact */}
          <div className="flex flex-col items-center p-4 sm:p-0">
            <div className="w-12 h-12 rounded-full bg-gradient-to-r from-gray-700 to-gray-900 flex items-center justify-center shadow-md mb-3">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                className="h-6 w-6 text-white"
                viewBox="0 0 24 24"
                fill="currentColor"
              >
                <path d="M12 0c-6.626 0-12 5.373-12 12 0 5.302 3.438 9.8 8.207 11.387.599.092.793-.217.793-.577v-2.234c-3.338.726-4.033-1.416-4.033-1.416-.546-1.387-1.333-1.756-1.333-1.756-1.089-.745.083-.729.083-.729 1.205.084 1.839 1.237 1.839 1.237 1.07 1.834 2.807 1.304 3.492.997.107-.775.418-1.305.762-1.604-2.665-.305-5.467-1.334-5.467-5.931 0-1.311.469-2.381 1.236-3.221-.124-.303-.535-1.524.117-3.176 0 0 1.008-.322 3.301 1.23.957-.266 1.983-.399 3.003-.404 1.02.005 2.047.138 3.006.404 2.291-1.552 3.297-1.23 3.297-1.23.653 1.653.242 2.874.118 3.176.77.84 1.235 1.911 1.235 3.221 0 4.609-2.339 4.687-4.565 4.928.359.309.678.92.678 1.855 0 1.338-.012 2.419-.012 2.747 0 .267.18.578.688.48C19.138 20.161 22 16.416 22 12c0-6.627-5.373-12-12-12z" />
              </svg>
            </div>
            <p className="font-medium text-gray-700 dark:text-gray-300 mb-1 text-center">
              GitHub
            </p>
            <a
              href="https://github.com/AliSafari-IT"
              target="_blank"
              rel="noopener noreferrer"
              className="group inline-flex items-center"
            >
              <span className="text-teal-600 dark:text-teal-400 font-medium group-hover:text-gray-700 dark:group-hover:text-gray-300 transition-colors duration-300 hover:underline">
                github.com/AliSafari-IT
              </span>
              <span className="ml-2 opacity-0 group-hover:opacity-100 transition-opacity duration-300">
                <svg 
                  xmlns="http://www.w3.org/2000/svg" 
                  className="h-4 w-4 text-gray-700 dark:text-gray-300" 
                  viewBox="0 0 20 20" 
                  fill="currentColor"
                >
                  <path d="M11 3a1 1 0 100 2h2.586l-6.293 6.293a1 1 0 101.414 1.414L15 6.414V9a1 1 0 102 0V4a1 1 0 00-1-1h-5z" />
                  <path d="M5 5a2 2 0 00-2 2v8a2 2 0 002 2h8a2 2 0 002-2v-3a1 1 0 10-2 0v3H5V7h3a1 1 0 000-2H5z" />
                </svg>
              </span>
            </a>
          </div>

          {/* LinkedIn Contact */}
          <div className="flex flex-col items-center p-4 sm:p-0">
            <div className="w-12 h-12 rounded-full bg-gradient-to-r from-blue-500 to-blue-700 flex items-center justify-center shadow-md mb-3">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                className="h-6 w-6 text-white"
                viewBox="0 0 24 24"
                fill="currentColor"
              >
                <path d="M19 0h-14c-2.761 0-5 2.239-5 5v14c0 2.761 2.239 5 5 5h14c2.762 0 5-2.239 5-5v-14c0-2.761-2.238-5-5-5zm-11 19h-3v-11h3v11zm-1.5-12.268c-.966 0-1.75-.79-1.75-1.764s.784-1.764 1.75-1.764 1.75.79 1.75 1.764-.783 1.764-1.75 1.764zm13.5 12.268h-3v-5.604c0-3.368-4-3.113-4 0v5.604h-3v-11h3v1.765c1.396-2.586 7-2.777 7 2.476v6.759z" />
              </svg>
            </div>
            <p className="font-medium text-gray-700 dark:text-gray-300 mb-1 text-center">
              LinkedIn
            </p>
            <a
              href="https://linkedin.com/in/ali-safari-m"
              target="_blank"
              rel="noopener noreferrer"
              className="group inline-flex items-center"
            >
              <span className="text-teal-600 dark:text-teal-400 font-medium group-hover:text-blue-500 dark:group-hover:text-blue-300 transition-colors duration-300 hover:underline">
                linkedin.com/in/ali-safari-m
              </span>
              <span className="ml-2 opacity-0 group-hover:opacity-100 transition-opacity duration-300">
                <svg 
                  xmlns="http://www.w3.org/2000/svg" 
                  className="h-4 w-4 text-blue-500" 
                  viewBox="0 0 20 20" 
                  fill="currentColor"
                >
                  <path d="M11 3a1 1 0 100 2h2.586l-6.293 6.293a1 1 0 101.414 1.414L15 6.414V9a1 1 0 102 0V4a1 1 0 00-1-1h-5z" />
                  <path d="M5 5a2 2 0 00-2 2v8a2 2 0 002 2h8a2 2 0 002-2v-3a1 1 0 10-2 0v3H5V7h3a1 1 0 000-2H5z" />
                </svg>
              </span>
            </a>
          </div>

          {/* Phone Contact */}
          <div className="flex flex-col items-center p-4 sm:p-0">
            <div className="w-12 h-12 rounded-full bg-gradient-to-r from-teal-500 to-blue-500 flex items-center justify-center shadow-md mb-3">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                className="h-6 w-6 text-white"
                viewBox="0 0 20 20"
                fill="currentColor"
              >
                <path d="M2 3a1 1 0 011-1h2.153a1 1 0 01.986.836l.74 4.435a1 1 0 01-.54 1.06l-1.548.773a11.037 11.037 0 006.105 6.105l.774-1.548a1 1 0 011.059-.54l4.435.74a1 1 0 01.836.986V17a1 1 0 01-1 1h-2C7.82 18 2 12.18 2 5V3z" />
              </svg>
            </div>
            <p className="font-medium text-gray-700 dark:text-gray-300 mb-1 text-center">
              Phone
            </p>
            <a
              href="tel:+32484995707"
              className="group inline-flex items-center"
              aria-label="Call (0484) 995-707"
              title="Call (0484) 995-707"
            >
              <span className="text-teal-600 dark:text-teal-400 font-medium group-hover:text-teal-500 dark:group-hover:text-teal-300 transition-colors duration-300 hover:underline">
                (0484) 995-707
              </span>
              <span className="ml-2 opacity-0 group-hover:opacity-100 transition-opacity duration-300">
                <svg 
                  xmlns="http://www.w3.org/2000/svg" 
                  className="h-4 w-4 text-teal-500" 
                  viewBox="0 0 20 20" 
                  fill="currentColor"
                >
                  <path d="M2 3a1 1 0 011-1h2.153a1 1 0 01.986.836l.74 4.435a1 1 0 01-.54 1.06l-1.548.773a11.037 11.037 0 006.105 6.105l.774-1.548a1 1 0 011.059-.54l4.435.74a1 1 0 01.836.986V17a1 1 0 01-1 1h-2C7.82 18 2 12.18 2 5V3z" />
                </svg>
              </span>
            </a>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ContactInfo;
