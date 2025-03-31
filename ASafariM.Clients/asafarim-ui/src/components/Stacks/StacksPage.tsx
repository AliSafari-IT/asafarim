import React, { useState, useEffect, useMemo } from "react";
import "./StacksPage.css";
import { Modal, SearchBox } from "@fluentui/react";
import { Tooltip } from "@material-tailwind/react";
import transformMdFilesToStackData from "./transformMdFilesToStackData";
import { IMenuItem } from "@/interfaces/IMenuItem";
import getSlug from "@/utils/getSlug";
import generateCategoryColors from "@/utils/categoryColors";
import determineTextColor from "@/utils/determineTextColor";
import { getFirstHeading } from "@/utils/mdUtils";
import Wrapper from "@/layout/Wrapper/Wrapper";
import { logger } from "@/utils/logger";

interface StacksPageProps {
  docBranch: string;
  stackTitle: string;
}

const StacksPage: React.FC<StacksPageProps> = ({ docBranch, stackTitle }) => {
  const [selectedStack, setSelectedStack] = useState<IMenuItem | null>(null);
  const [searchTerm, setSearchTerm] = useState("");
  const [dynamicStackData, setDynamicStackData] = useState<
    Record<string, IMenuItem[]>
  >({});
  const [stacksHeaderBgColor, setStacksHeaderBgColor] = useState<string>();
  const [stacksHeaderTextColor, setStacksHeaderTextColor] = useState<string>();
  const [isLoading, setIsLoading] = useState(true);

  const basePath =
    docBranch === "techDocs"
      ? "/tech-docs"
      : docBranch === "changelogs"
      ? "/changelogs"
      : "/legal-docs";

  useEffect(() => {
    setIsLoading(true);
    const transformedData = transformMdFilesToStackData(docBranch);
    logger.log("Transformed Stack Data:", transformedData);
    setDynamicStackData(transformedData);
    setIsLoading(false);
  }, [docBranch]);

  useEffect(() => {
    if (!stacksHeaderBgColor) {
      setStacksHeaderBgColor(
        document.getElementById("stacks-header")?.style.backgroundColor
      );
    }

    if (!stacksHeaderTextColor && stacksHeaderBgColor) {
      const currentTheme =
        document.documentElement.getAttribute("data-theme") || "light";
      const stacksHeaderTextColor = determineTextColor(
        currentTheme,
        stacksHeaderBgColor
      );
      setStacksHeaderTextColor(stacksHeaderTextColor);
    }
  }, [stacksHeaderBgColor, stacksHeaderTextColor]);

  const currentTheme =
    document.documentElement.getAttribute("data-theme") || "light";

  const handleCardClick = (stack: IMenuItem) => {
    setSelectedStack(stack);
  };

  const closeModal = () => {
    setSelectedStack(null);
  };

  const handleClear = () => setSearchTerm("");

  const handleSearch = (e?: { target: { value: string } }) => {
    if (e) {
      setSearchTerm(e.target.value?.toLowerCase());
    }
  };

  const filteredData = Object.entries(dynamicStackData).reduce(
    (acc, [category, stacks]) => {
      const filteredStacks = stacks?.filter((stack) => {
        const stackName = stack?.title?.toLowerCase();
        const stackDescription = stack?.description?.toLowerCase();
        const stackContent = stack?.content?.toLowerCase();
        return (
          stackName?.includes(searchTerm) ||
          stackDescription?.includes(searchTerm) ||
          stackContent?.includes(searchTerm)
        );
      });
      if (filteredStacks?.length) {
        acc[category] = filteredStacks;
      }
      return acc;
    },
    {} as typeof dynamicStackData
  );

  const categoryColors = useMemo(
    () => generateCategoryColors(Object.keys(filteredData)),
    [filteredData]
  );

  function navigateToProjects({
    selected,
    parentFolder,
  }: { selected?: IMenuItem; parentFolder?: string } = {}): void {
    if (!selected || !selected.name) {
      logger.warn("navigateToProjects: Missing selected stack or name.");
      return;
    }

    const slug = getSlug(selected.name);
    logger.log("Slug:", slug);
    const normalizedParentFolder = parentFolder
      ? parentFolder.replace(/\/+$/, "") // Remove trailing slashes
      : basePath;

    const navto =
      docBranch === "changelogs"
        ? `${basePath}/${slug}`
        : `${normalizedParentFolder}/${slug}`.replace(/\/+/g, "/");

    logger.log("Navigate to:", navto);
    window.location.href = navto;
  }

  function getParentFolders(path: string): string {
    if (!path) {
      logger.warn("getParentFolder: Received an empty path.");
      return "";
    }

    // Remove any relative path notations like ../../ and normalize slashes
    const sanitizedPath = path
      .replace(/\.\.\//g, "")
      .replace(/\\/g, "/")
      .replace(/\/$/, "");

    // Split the path into parts
    const parts = sanitizedPath.split("/");

    // Check if the path contains "docs/TechDocs"
    const techDocsIndex = parts.indexOf("docs");
    if (techDocsIndex !== -1 && parts[techDocsIndex + 1] === "TechDocs") {
      parts.splice(0, techDocsIndex + 2); // Remove everything up to and including "docs/TechDocs"
    }

    if (parts.length <= 1) {
      logger.warn(
        `getParentFolder: Path "${path}" does not have a parent folder.`
      );
      return basePath; // Default to basePath if no parent exists
    }

    // Remove the last part (assumed to be the file or current folder)
    parts.pop();

    // Join the remaining parts to reconstruct the parent folder path
    const parentFolders = `${basePath}/${parts.join("/")}`.replace(/\/+/g, "/"); // Normalize slashes
    return parentFolders; // Return the valid parent folder path relative to basePath
  }

  return (
    <Wrapper footer={<></>} removeNavbar>
      <div className="container mx-auto px-4 py-8">
        {/* Page Header */}
        <div className="bg-white dark:bg-gray-800 shadow-lg rounded-lg overflow-hidden mb-6">
          <div className="bg-gradient-to-r from-[var(--info-light)] to-[var(--info)] p-6">
            <h1 className="text-2xl font-bold text-white">{stackTitle}</h1>
            <p className="text-white opacity-90">
              Browse and explore available technology stacks
            </p>
          </div>

          {/* Search Bar */}
          <div className="p-4 bg-white dark:bg-gray-800">
            <SearchBox
              value={searchTerm}
              onChange={handleSearch}
              onClear={handleClear}
              onEscape={handleClear}
              onAbort={handleClear}
              onSearch={handleClear}
              className="stacks-search-bar"
              placeholder="Search stacks..."
            />
          </div>
        </div>

        {/* Loading State */}
        {isLoading ? (
          <div className="flex justify-center items-center h-64">
            <div className="animate-spin rounded-full h-16 w-16 border-t-2 border-b-2 border-[var(--info)]"></div>
          </div>
        ) : (
          /* Categories and Stacks */
          <div className="categories-container">
            {Object.entries(filteredData)?.length > 0 ? (
              Object.entries(filteredData)?.map(([category, stackItems]) => {
                const categoryStyle =
                  categoryColors[category] || categoryColors.default;

                stackItems.map((stack) => {
                  stack.color = categoryStyle.color;
                  stack.textColor = determineTextColor(
                    currentTheme,
                    categoryStyle.color
                  );
                });

                return (
                  <div key={category} className="category-section mb-8">
                    <div
                      className="category-header mb-4 px-4 py-3 rounded-lg shadow-md"
                      style={{
                        backgroundColor: categoryStyle.color,
                        color: categoryStyle.textColor,
                      }}
                    >
                      <h2 className="text-xl font-bold">
                        {stackItems[0].parentFolder || category}
                      </h2>
                    </div>

                    <div className="stack-grid">
                      {stackItems.length > 0 ? (
                        stackItems.map((stack, index) => (
                          <Tooltip
                            key={index}
                            content={
                              stack.description ??
                              (stack.content
                                ? getFirstHeading(stack.content)
                                : stack.title ?? stack.name)
                            }
                          >
                            <div
                              className="stack-card"
                              onClick={() => handleCardClick(stack)}
                            >
                              <div className="stack-card-inner">
                                <div
                                  className="stack-icon"
                                  style={{ backgroundColor: stack.color }}
                                >
                                  {stack.name.charAt(0).toUpperCase()}
                                </div>
                                <span className="stack-name">
                                  {stack.content
                                    ? getFirstHeading(stack.content)
                                    : stack.title ?? stack.name}
                                </span>
                              </div>
                            </div>
                          </Tooltip>
                        ))
                      ) : (
                        <p className="text-gray-500 dark:text-gray-400 italic">
                          No stacks available in this category.
                        </p>
                      )}
                    </div>
                  </div>
                );
              })
            ) : (
              <div className="empty-state text-center py-16">
                <div className="text-gray-400 text-6xl mb-4">
                  <i className="fas fa-layer-group"></i>
                </div>
                <h3 className="text-xl font-semibold text-gray-600 dark:text-gray-300 mb-2">
                  No Stacks Found
                </h3>
                <p className="text-gray-500 dark:text-gray-400">
                  {searchTerm
                    ? `No results match "${searchTerm}"`
                    : "There are no technology stacks available."}
                </p>
                {searchTerm && (
                  <button
                    onClick={handleClear}
                    className="mt-4 px-4 py-2 bg-[var(--info)] text-white rounded-md hover:bg-[var(--info-dark)] transition-colors"
                  >
                    Clear Search
                  </button>
                )}
              </div>
            )}
          </div>
        )}

        {/* Modal */}
        {selectedStack && (
          <Modal
            isOpen={true}
            onDismiss={closeModal}
            isBlocking={true}
            containerClassName="stack-modal-container"
          >
            <div className="stack-modal-content w-full max-w-[95vw] md:max-w-[600px] mx-auto my-4">
              <div className="modal-header bg-gradient-to-r from-[var(--info-light)] to-[var(--info)] p-4 rounded-t-lg">
                <h2 className="text-xl font-bold text-white">
                  {selectedStack.name}
                </h2>
              </div>

              <div className="modal-body p-4 md:p-6 max-h-[70vh] overflow-y-auto">
                {selectedStack.description && (
                  <p className="text-gray-700 dark:text-gray-300 mb-4 md:mb-6">
                    {selectedStack.description}
                  </p>
                )}

                <div className="stack-details">
                  {selectedStack.content && (
                    <div className="mb-4">
                      <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)] mb-2">
                        Content
                      </h3>
                      <p className="text-gray-700 dark:text-gray-300">
                        {getFirstHeading(selectedStack.content)}
                      </p>
                    </div>
                  )}
                </div>
              </div>

              <div className="modal-footer bg-gray-50 dark:bg-gray-800 p-4 rounded-b-lg flex flex-col md:flex-row justify-between gap-2">
                <button
                  onClick={closeModal}
                  className="w-full md:w-auto px-4 py-2 border border-gray-300 dark:border-gray-600 bg-white dark:bg-gray-700 text-gray-700 dark:text-gray-200 rounded-md hover:bg-gray-100 dark:hover:bg-gray-600 transition-colors"
                >
                  Close
                </button>

                <button
                  onClick={(e) => {
                    e?.preventDefault();
                    const parentFolderName = getParentFolders(
                      selectedStack.folderName || selectedStack.filepath || ""
                    );
                    navigateToProjects({
                      selected: selectedStack,
                      parentFolder: parentFolderName,
                    });
                  }}
                  className="px-4 py-2 bg-blue-600 dark:bg-blue-700 text-white rounded-md hover:bg-blue-700 dark:hover:bg-blue-800 transition-colors"
                >
                  View Details
                </button>
              </div>
            </div>
          </Modal>
        )}
      </div>
    </Wrapper>
  );
};

export default StacksPage;
