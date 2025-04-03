import React from "react";

const ASMButton: React.FC = () => {
    return (
        <button
            onClick={() => window.open("https://pbk.asafarim.com", "_blank")}
            className="bg-gradient-to-r from-[var(--button-bg, #41D1FF)] to-[var(--button-hover-bg, #BD34FE)] text-[var(--button-text, white)] px-6 py-2 rounded-md flex items-center space-x-2 shadow-md hover:scale-105 transition-transform dark:bg-gradient-to-r dark:from-[var(--button-bg, #BD34FE)] dark:to-[var(--button-hover-bg, #41D1FF)] dark:text-[var(--button-text, white)]"
        >
            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 256 256" width="24" height="24">
                <defs>
                    <linearGradient id="gradient1" x1="0%" y1="0%" x2="100%" y2="100%">
                        <stop offset="0%" stopColor="#41D1FF" />
                        <stop offset="100%" stopColor="#BD34FE" />
                    </linearGradient>
                </defs>
                <rect width="256" height="256" rx="20" fill="url(#gradient1)" />
                <text x="50%" y="55%" fontSize="90" fontFamily="Arial, sans-serif" fontWeight="bold" fill="white" textAnchor="middle" dominantBaseline="middle">
                    CV
                </text>
            </svg>
            <span className="font-semibold text-lg">Resume</span>
        </button>
    );
};

export default ASMButton;
