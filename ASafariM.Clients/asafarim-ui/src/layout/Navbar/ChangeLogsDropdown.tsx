import React, { useEffect, useRef, useState } from "react";
import { getAllMdFiles } from "@/utils/mdFilesUtils";
import { getFirstHeading } from "@/utils/mdUtils";
import { FaRegFileAlt } from 'react-icons/fa';
import { FaChevronLeft, FaChevronRight } from 'react-icons/fa';

const ChangeLogsDropdown: React.FC<{ mobileView: boolean }> = ({ mobileView }) => {
  const [isOpen, setIsOpen] = useState(false); // State to manage dropdown visibility
  const mdFiles = getAllMdFiles(); // Get Markdown files
  const changelogs = mdFiles?.changelogs?.subMenu || []; // Ensure safe access to changelog items
  const dropdownRef = useRef<HTMLDivElement>(null);
  
  // Pagination state
  const [currentPage, setCurrentPage] = useState(1);
  const itemsPerPage = 10; // Number of items to display per page

  // Toggle dropdown visibility
  const toggleDropdown = () => setIsOpen((prev) => !prev);

  const sortedChangeLogs = {
    ...mdFiles.changelogs,
    subMenu: [...(mdFiles.changelogs.subMenu || [])].sort((a, b) => {
      const dateA =  new Date(a.updatedAt || a.createdAt || 0).getTime();
      const dateB = new Date(b.updatedAt || b.createdAt || 0).getTime();
      return dateB - dateA; // Sort descending (newest first)
    }),
  };
  
  // Calculate pagination values
  const totalItems = sortedChangeLogs.subMenu.length;
  const totalPages = Math.ceil(totalItems / itemsPerPage);
  
  // Get current page items
  const getCurrentPageItems = () => {
    const startIndex = (currentPage - 1) * itemsPerPage;
    const endIndex = startIndex + itemsPerPage;
    return sortedChangeLogs.subMenu.slice(startIndex, endIndex);
  };
  
  // Handle page navigation
  const goToNextPage = () => {
    if (currentPage < totalPages) {
      setCurrentPage(currentPage + 1);
    }
  };
  
  const goToPreviousPage = () => {
    if (currentPage > 1) {
      setCurrentPage(currentPage - 1);
    }
  };

  // Close dropdown if clicked outside
  useEffect(() => {
    const handleClickOutside = (event: MouseEvent) => {
      if (dropdownRef.current && !dropdownRef.current.contains(event.target as Node)) {
        setIsOpen(false);
      }
    };

    document.addEventListener("mousedown", handleClickOutside);
    return () => document.removeEventListener("mousedown", handleClickOutside);
  }, []);

  return (
    <div className="relative inline-block text-left " ref={dropdownRef} >
      {/* Dropdown Button with no title but an icon*/}
      <button
        onClick={toggleDropdown}
        aria-expanded={isOpen}
        aria-controls="changelog-menu"
        className="text-[var(--text-primary)] transition-all duration-200 hover:text-[var(--text-secondary)]"
      >
        <FaRegFileAlt className="inline-block m-2" />
        {`${changelogs.length} logs `}
      </button>

      {/* Dropdown Menu */}
      {isOpen && (
        <div className={`${mobileView ? "absolute left-0" : "absolute right-0"} mt-2 w-56 rounded-md shadow-lg bg-white dark:bg-gray-800 z-10`}>
          <ul
            id="changelog-menu"
            className="overflow-y-auto max-h-64"
          >
            {getCurrentPageItems().map((file) => (
              <li
                key={file.id}
                className="p-2 cursor-pointer hover:bg-gray-100 dark:hover:bg-gray-700 font-light text-sm"
              >
                <a
                  href={file.to}
                  title={getFirstHeading(file.content || "") || file.title || "Untitled"}
                  className="block text-gray-800 dark:text-gray-200 truncate max-w-[250px]"
                >
                  {getFirstHeading(file.content || "") || file.title || "Untitled"}
                </a>
              </li>
            ))}
          </ul>
          
          {/* Pagination controls */}
          {totalPages > 1 && (
            <div className="flex justify-between items-center p-2 border-t border-gray-200 dark:border-gray-700">
              <button 
                onClick={goToPreviousPage} 
                disabled={currentPage === 1}
                className={`p-1 rounded ${currentPage === 1 ? 'text-gray-400 cursor-not-allowed' : 'text-blue-500 hover:bg-gray-100 dark:hover:bg-gray-700'}`}
              >
                <FaChevronLeft size={14} />
              </button>
              <span className="text-xs text-gray-600 dark:text-gray-300">
                {currentPage} / {totalPages}
              </span>
              <button 
                onClick={goToNextPage} 
                disabled={currentPage === totalPages}
                className={`p-1 rounded ${currentPage === totalPages ? 'text-gray-400 cursor-not-allowed' : 'text-blue-500 hover:bg-gray-100 dark:hover:bg-gray-700'}`}
              >
                <FaChevronRight size={14} />
              </button>
            </div>
          )}
        </div>
      )}
    </div>
  );
};

export default ChangeLogsDropdown;
