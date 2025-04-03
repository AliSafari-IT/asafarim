import React from "react";

interface ResumeButtonProps {
  displayType?: "text" | "icon";
  className?: string;
}

const ResumeButton: React.FC<ResumeButtonProps> = ({
  displayType = "text",
  className,
}) => {

  return (
    <button
      onClick={() => window.open("https://pbk.asafarim.com", "_blank")}
      className={`bg-teams-purple text-white px-4 py-2 rounded-md shadow-md hover:bg-teams-purple-light transition-all flex items-center space-x-2 ${className}`}
    >
      {displayType === "text" ? (
        <span className="text-lg font-semibold">Resume</span>
      ) : (
        <svg
          xmlns="http://www.w3.org/2000/svg"
          viewBox="0 0 24 24"
          fill="currentColor"
          className="w-6 h-6"
        >
          <path
            fillRule="evenodd"
            d="M6 2h12a2 2 0 012 2v16a2 2 0 01-2 2H6a2 2 0 01-2-2V4a2 2 0 012-2zm1 2v16h10V4H7zm4 10a2 2 0 100-4 2 2 0 000 4zm-3-8h8v2H8V6zm0 4h8v2H8v-2z"
            clipRule="evenodd"
          />
        </svg>
      )}
    </button>
  );
};

export default ResumeButton;
