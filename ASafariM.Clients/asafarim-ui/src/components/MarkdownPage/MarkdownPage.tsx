import React, { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { IMenuItem } from "@/interfaces/IMenuItem";
import Wrapper from "@/layout/Wrapper";
import Header from "@/layout/Header/Header";
import DisplayMd from "./DisplayMd";
import { Breadcrumb, IBreadcrumbItem } from "@fluentui/react/lib/Breadcrumb";
import ScrollingButtons from "../ScrollingButtons";
import { getFirstHeading } from "@/utils/mdUtils";
import SortArray, { SortOrder } from "@/components/SortArray";
import {logger} from '@/utils/logger';

const BackIcon = () => (
  <svg
    xmlns="http://www.w3.org/2000/svg"
    viewBox="0 0 24 24"
    className="w-6 h-6"
  >
    <path
      fill="currentColor"
      d="M20 11H7.83l5.59-5.59L12 4l-8 8 8 8 1.41-1.41L7.83 13H20v-2z"
    ></path>
  </svg>
);

const MarkdownPage: React.FC<{
  data: IMenuItem;
  title?: string;
  description?: string;
  baseUrl?: string;
}> = ({ data, title, description, baseUrl }) => {
  const { categories, topics, sections, chapters, slug } = useParams<{
    categories?: string;
    topics?: string;
    sections?: string;
    chapters?: string;
    slug?: string;
  }>();
  const navigate = useNavigate();
  const [currentDirectory, setCurrentDirectory] = useState<
    IMenuItem | undefined
  >();
  const [currentMdFile, setCurrentMdFile] = useState<IMenuItem | undefined>();
  const [pageTitle, setPageTitle] = useState(title || "");
  const [viewportHeight, setViewportHeight] = useState(window.innerHeight);
  const [sortOrder, setSortOrder] = useState<SortOrder>("desc");

  // get current viewport height
  useEffect(() => {
    const handleResize = () => {
      setViewportHeight(window.innerHeight);
    };
    window.addEventListener("resize", handleResize);
    return () => {
      window.removeEventListener("resize", handleResize);
    };
  }, []);

  // get height of markdown-container element
  const markdownContainerHeight =
    document.getElementById("markdown-container")?.clientHeight || 0;

  // add page title
  useEffect(() => {
    document.title = pageTitle;
    logger.debug(pageTitle, description);
  }, [description, pageTitle]);

  useEffect(() => {
    let current = data; // Start with the root directory
    const pathSegments = [categories, topics, sections, chapters, slug].filter(
      Boolean
    );

    for (let i = 0; i < pathSegments.length; i++) {
      const segment = pathSegments[i];
      const foundItem = current.subMenu?.find(
        (item) => item.name.toLowerCase() === segment?.toLowerCase()
      );

      if (!foundItem) {
        setCurrentDirectory(current); // Set to current level if nothing is found
        setCurrentMdFile(undefined);
        return;
      }

      if (foundItem.type === "file") {
        setCurrentMdFile(foundItem); // Set current Markdown file
        setCurrentDirectory(undefined);
        return;
      }

      // If it's a folder, dive deeper
      current = foundItem;
      setCurrentDirectory(current);
      setCurrentMdFile(undefined);
    }

    // If no path segments, show the root directory
    if (pathSegments.length === 0) {
      setCurrentDirectory(data);
      setCurrentMdFile(undefined);
    }
  }, [data, categories, topics, sections, chapters, slug]);

  useEffect(() => {
    if (currentMdFile) {
      setPageTitle(currentMdFile.title || "");
    } else if (currentDirectory) {
      setPageTitle(currentDirectory.title || "");
    }
  }, [currentDirectory, currentMdFile]);

  const handleBackToList = () => {
    const pathParts = window.location.pathname.split("/").filter(Boolean);
    if (pathParts.length > 1) {
      pathParts.pop();
      navigate("/" + pathParts.join("/"));
    } else {
      navigate("/");
    }
  };

  const renderBreadcrumbs = () => {
    const items: IBreadcrumbItem[] = [];

    if (categories)
      items.push({
        text: categories,
        key: categories,
        href: `${baseUrl}/${categories}`,
      });
    if (topics)
      items.push({
        text: topics,
        key: topics,
        href: `${baseUrl}/${categories}/${topics}`,
      });
    if (sections)
      items.push({
        text: sections,
        key: sections,
        href: `${baseUrl}/${categories}/${topics}/${sections}`,
      });
    if (chapters)
      items.push({
        text: getFirstHeading(currentMdFile?.content || "") ?? chapters,
        key: chapters,
        href: `${baseUrl}/${categories}/${topics}/${sections}/${chapters}`,
      });

    return (
      <Breadcrumb
        items={items}
        maxDisplayedItems={5}
        ariaLabel="Breadcrumb"
        styles={{
          root: { marginBottom: "16px" },
        }}
      />
    );
  };

  const renderDirectoryContent = () => {
    const folders = currentDirectory?.subMenu?.filter(
      (item) => item.type === "folder"
    );
    const files = currentDirectory?.subMenu?.filter(
      (item) => item.type === "file"
    );

    function getLastChangedAt(
      createdAt: Date | undefined,
      updatedAt: Date | undefined
    ): React.ReactNode {
      const formatDate = (date: Date): string => {
        const options: Intl.DateTimeFormatOptions = {
          day: "2-digit",
          month: "2-digit",
          year: "numeric",
          hour: "numeric",
          minute: "numeric",
          hour12: true,
        };
        return date.toLocaleString("en-GB", options).replace(",", "");
      };

      if (createdAt && updatedAt) {
        return formatDate(
          new Date(Math.max(createdAt.getTime(), updatedAt.getTime()))
        );
      } else if (updatedAt) {
        return formatDate(updatedAt);
      } else if (createdAt) {
        return formatDate(createdAt);
      } else {
        return "Not available";
      }
    }

    const handleSortChange = (newOrder: SortOrder) => {
      setSortOrder(newOrder);
    };

    return (
      <div>
        {(folders || files) && (
          <table className="table-auto w-full text-left border-collapse">
            <thead>
              <tr className="bg-secondary text-primary">
                <th className="p-4 w-5 text-center whitespace-nowrap">Type</th>
                <th className="p-4 w-2/5">Name</th>
                <th className="p-4 w-1/5">
                  Last Modified
                  <SortArray
                    sortOrder={sortOrder}
                    onSortChange={handleSortChange}
                    key={"last-modified-col"}
                  />
                </th>
                <th className="p-4 w-20 text-center whitespace-nowrap">Actions</th>
              </tr>
            </thead>
            <tbody>
              {folders &&
                folders.map((folder) => (
                  <tr key={folder.id} className="hover:bg-primary transition">
                    <td className="p-4 w-5 text-center whitespace-nowrap text-info" title="Folder">
                      📂
                    </td>
                    <td className="p-4 w-2/5">
                      <a
                        href={folder.to || "#"}
                        className="hover:underline text-teams-purple"
                        onClick={(e) => {
                          e.preventDefault();
                          navigate(folder.to || "#");
                        }}
                      >
                        {folder.title}
                      </a>
                    </td>
                    <td className="p-4 w-1/5">
                      {getLastChangedAt(folder.createdAt, folder.updatedAt) ||
                        "No date available"}
                    </td>
                    <td className="p-4 w-20">
                      <button
                        className="btn-secondary"
                        onClick={() => navigate(folder.to || "#")}
                        title="View Folder"
                      >
                        🔍
                      </button>
                    </td>
                  </tr>
                ))}
              {files &&
                files
                  .map((log) => {
                    // Get the most recent date (either updated or created)
                    const mostRecentDate = log.updatedAt ?? log.createdAt;
                    return {
                      ...log,
                      title: log.content
                        ? getFirstHeading(log.content)
                        : "No title",
                      mostRecentDate,
                    };
                  })
                  .sort((a, b) => {
                    const dateA = a.mostRecentDate?.getTime() || 0;
                    const dateB = b.mostRecentDate?.getTime() || 0;
                    return sortOrder === "desc" ? dateB - dateA : dateA - dateB;
                  })
                  .map((file) => (
                    <tr key={file.id} className="hover:bg-primary transition">
                      <td className="p-4 w-5 text-center whitespace-nowrap text-info" title="File">
                        📄
                      </td>
                      <td className="p-4 w-2/5">
                        <a
                          href={file.to || "#"}
                          className="hover:underline text-teams-blue"
                          onClick={(e) => {
                            e.preventDefault();
                            navigate(file.to || "#");
                          }}
                        >
                          {getFirstHeading(file.content || "") || file.title}
                        </a>
                      </td>
                      <td className="p-4 w-1/5">
                        {getLastChangedAt(file.createdAt, file.updatedAt)}
                      </td>
                      <td className="p-4 w-20">
                        <button
                          className="btn-secondary"
                          onClick={() => navigate(file.to || "#")}
                          title="View File"
                        >
                          👁️
                        </button>
                      </td>
                    </tr>
                  ))}
            </tbody>
          </table>
        )}
      </div>
    );
  };

  const renderMarkdownContent = () => (
    <div className="prose dark:prose-invert max-w-none" id="markdown-container">
      <DisplayMd
        id={currentMdFile?.id}
        markdownContent={currentMdFile?.content || ""}
        key={currentMdFile?.id}
      />
    </div>
  );

  return (
    <Wrapper
      header={
        <Header>
          <div className="w-full max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
            <div className="py-6 flex items-center justify-between">
              <div className="py-6">
                {renderBreadcrumbs()} {/* Render Fluent UI breadcrumbs */}
              </div>
              <button
                onClick={handleBackToList}
                className="inline-flex items-center gap-2 text-info-dark hover:text-info transition-colors duration-200"
              >
                <BackIcon />
                <span className="font-medium">
                  {!categories && !slug ? " 🏠 " : "Back to List"}
                </span>
              </button>
            </div>
          </div>
        </Header>
      }
    >
      <div className="w-full max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
        <div className="py-6">
          {currentMdFile ? renderMarkdownContent() : renderDirectoryContent()}
        </div>
      </div>
      {/* Show ScrollingButtons when on the markdown page and the content height is greater than the viewport height */}
      {currentMdFile && markdownContainerHeight > viewportHeight && (
        <div className="fixed bottom-4 right-4 z-50">
          <ScrollingButtons />
        </div>
      )}
    </Wrapper>
  );
};

export default MarkdownPage;
