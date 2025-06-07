// E:\asm-fs\apps\frontends\asafarim-client\src\pages\Home\HomePanels.tsx
import { useRef, useState } from "react";
import "./home.css";
import DisplayMd from "@/components/MarkdownPage/DisplayMd";
//import Modal from '@/components/Containers/Modal/Modal';
import Barchart from "@/components/D3/Barchart";
import LineChart from "@/components/D3/LineChart";
import Scatterplot from "@/components/D3/Scatterplot";
import Toolbar from "@/components/Toolbars/Toolbar";
import { Modal, ResponsiveMode } from "@fluentui/react";
import { FaDownload, FaTimes } from "react-icons/fa";
import { TreemapChart, TreeMapData } from "@/components/D3/TreeMapChart";
import { IAlign } from "@/interfaces/IAlign";
import StacksPage from "../../components/Stacks/StacksPage";
import StackedAreaChart from "@/components/D3/StackedAreaChart";
import StackedBarChart from "@/components/D3/StackedBarChart";
import WordCloudChart from "@/components/D3/WordCloudChart";
import StackedColumnChart from "@/components/D3/StackedColumnChart";
import StackedLineChart from "@/components/D3/StackedLineChart";
import TimeSeriesChart from "@/components/D3/TimeSeriesChart";
import Header from "@/layout/Header/Header";
import * as d3 from "d3";
import ErrorBoundary from "@/components/D3/ErrorBoundary";
import { Hierarchy } from "@/components/D3/Hierarchy";
import { treeMapData2 } from "@/components/D3/data/treeMapData2";
import { logger } from "@/utils/logger";

interface Data {
  date: Date | null;
  price: number;
}

interface Line {
  name: string;
  values: Data[];
}

const parseDate = d3.timeParse("%Y-%m");

const dataLineChart: Line[] = [
  {
    name: "NAFTA",
    values: [
      { date: "2020-01", price: 0 },
      { date: "2020-02", price: 500 },
      { date: "2020-03", price: 1500 },
      { date: "2020-04", price: 3000 },
      { date: "2020-05", price: 3500 },
      { date: "2020-06", price: 4500 },
      { date: "2020-07", price: 4000 },
      { date: "2020-08", price: 4250 },
      { date: "2020-09", price: 5000 },
      { date: "2020-10", price: 3500 },
      { date: "2020-11", price: 4000 },
      { date: "2020-12", price: 4500 },
    ].map((line) => {
      const date = parseDate(line.date);

      return {
        date: date,
        price: line.price,
      };
    }),
  },
  {
    name: "Europe",
    values: [
      { date: "2020-01", price: 0 },
      { date: "2020-02", price: 400 },
      { date: "2020-03", price: 1200 },
      { date: "2020-04", price: 1700 },
      { date: "2020-05", price: 2100 },
      { date: "2020-06", price: 3500 },
      { date: "2020-07", price: 3000 },
      { date: "2020-08", price: 3250 },
      { date: "2020-09", price: 4500 },
      { date: "2020-10", price: 2200 },
      { date: "2020-11", price: 1300 },
      { date: "2020-12", price: 600 },
    ].map((line) => {
      const date = parseDate(line.date);

      return {
        date: date,
        price: line.price,
      };
    }),
  },
];

// Monthly hydrograph data of Rhine river, Germany
const monthlyHydrograph = [
  { DateTime: new Date("2022-01-01"), value: 1500 }, // Low flow in January
  { DateTime: new Date("2022-02-01"), value: 1800 }, // Slightly increasing flow in February
  { DateTime: new Date("2022-03-01"), value: 2200 }, // Increasing flow in March due to snowmelt
  { DateTime: new Date("2022-04-01"), value: 2800 }, // High flow in April due to snowmelt and rainfall
  { DateTime: new Date("2022-05-01"), value: 3200 }, // Peak flow in May due to heavy rainfall
  { DateTime: new Date("2022-06-01"), value: 2800 }, // Decreasing flow in June as rainfall decreases
  { DateTime: new Date("2022-07-01"), value: 2000 }, // Low flow in July due to dry weather
  { DateTime: new Date("2022-08-01"), value: 1800 }, // Slightly increasing flow in August due to occasional rainfall
  { DateTime: new Date("2022-09-01"), value: 1500 }, // Low flow in September due to dry weather
  { DateTime: new Date("2022-10-01"), value: 1200 }, // Very low flow in October due to drought
  { DateTime: new Date("2022-11-01"), value: 1000 }, // Extremely low flow in November due to drought
  { DateTime: new Date("2022-12-01"), value: 800 }, // Very low flow in December due to drought
];

// Word cloud data
const wordCloudData = [
  { word: "React TypeScript", count: 42 },
  { word: "MongoDb", count: 22 },
  { word: "MySQL", count: 30 },
  { word: "D3.js", count: 17 },
  { word: "DotNet", count: 65 },
  { word: "HTML", count: 37 },
  { word: "CSS", count: 21 },
];
// get md file content from d3jsReactUiContent as raw string
const d3jsReactUiContent = import.meta.glob("@mdfiles/TechDocs/**/*.md", {
  query: "raw",
  import: "default",
  eager: true,
});

const d3jsContentKey = Object.keys(d3jsReactUiContent).find((key) =>
  key.toLowerCase().endsWith("TechDocs/Projects/d3js-react-ui.md".toLowerCase())
);

const HomePanels = () => {
  const [selectedLinkId, setSelectedLinkId] = useState<number>(1);
  const [openDetailsId, setOpenDetailsId] = useState<number | null>(null);
  const [isMobileMenuOpen, setIsMobileMenuOpen] = useState(false);
  const [isModalOpen, setIsModalOpen] = useState(false);
  const [selectedComponent, setSelectedComponent] = useState<string | null>(
    null
  );
  const componentRef = useRef<HTMLDivElement>(null);
  const d3jsContent = d3jsContentKey ? (
    <div className="prose dark:prose-invert max-w-none" id="markdown-container">
      <DisplayMd
        id={"d3js-react-ui"}
        markdownContent={d3jsReactUiContent[d3jsContentKey] + "" || ""}
        key={`${d3jsContentKey}_`}
      />
    </div>
  ) : (
    "Content not found"
  );

  // Access the content
  const linkData = [
    {
      id: 1,
      title: "D3.js",
      content: d3jsContent,
      components: [
        "Barchart",
        "LineChart",
        "TreemapChart",
        "Hierarchy",
        "Scatterplot",
        "StackedAreaChart",
        "StackedBarChart",
        "StackedColumnChart",
        "StackedLineChart",
        "TimeSeriesChart",
        "WordCloudChart",
      ],
    },
    {
      id: 2,
      title: "Change Logs",
      content: <StacksPage docBranch="changelogs" stackTitle="Change Logs" />,
    },
    {
      id: 3,
      title: "Charts",
      content: (
        <Header color="red" size="text-3xl">
          {" "}
          Panel 3: Under Construction!{" "}
        </Header>
      ),
    },
  ];

  const selectedLink = linkData.find((link) => link.id === selectedLinkId);

  const handleLinkClick = (id: number) => {
    setSelectedLinkId(id);
    setIsMobileMenuOpen(false); // Close mobile menu after selection
  };

  const handleDetailsToggle = (id: number) => {
    setOpenDetailsId(openDetailsId === id ? null : id);
  };

  const handleComponentClick = (component: string) => {
    setSelectedComponent(component);
    setIsModalOpen(true);
  };

  const closeModal = () => {
    setSelectedComponent(null);
    setIsModalOpen(false);
  };

  const exportModalContent = (name: string) => {
    if (componentRef.current) {
      const svg = componentRef.current.querySelector("svg");
      if (svg) {
        const canvas = document.createElement("canvas");
        const ctx = canvas.getContext("2d");
        const svgData = new XMLSerializer().serializeToString(svg);
        const svgBlob = new Blob([svgData], {
          type: "image/svg+xml;charset=utf-8",
        });
        const url = URL.createObjectURL(svgBlob);

        const img = new Image();
        img.onload = () => {
          // Set canvas dimensions
          canvas.width = svg.clientWidth;
          canvas.height = svg.clientHeight;

          // Fill canvas with a white background
          ctx!.fillStyle = "#ffffff"; // Explicitly set white background
          ctx!.fillRect(0, 0, canvas.width, canvas.height);

          // Draw the SVG onto the canvas
          ctx!.drawImage(img, 0, 0, canvas.width, canvas.height);

          // Export the canvas as a JPEG
          const dataUrl = canvas.toDataURL("image/jpeg", 1.0);
          const link = document.createElement("a");
          link.href = dataUrl;
          link.download = `${name}.jpg`;
          link.click();

          // Clean up
          URL.revokeObjectURL(url);
        };
        img.onerror = () => {
          logger.error("Failed to load the SVG as an image.");
        };
        img.src = url;
      } else {
        logger.error("SVG element not found in the modal content.");
      }
    } else {
      logger.error("Component ref is null or undefined.");
    }
  };
  const dimensions = {
    width: 700,
    height: 500,
  };
  const d3Components = [
    <Barchart
      data={
        [
          { name: "A", value: 30 },
          { name: "B", value: 80 },
          { name: "C", value: 45 },
          { name: "D", value: 60 },
          { name: "E", value: 20 },
          { name: "F", value: 90 },
          { name: "G", value: 55 },
        ] as { name: string; value: number | undefined }[]
      }
      width={dimensions.width}
      height={dimensions.height}
    />,
    <LineChart
      width={dimensions.width}
      height={dimensions.height}
      data={dataLineChart}
    />,
    <Scatterplot
      data={[
        { x: 1, y: 7 },
        { x: 3, y: 4 },
        { x: 5, y: 26 },
        { x: 7, y: 8 },
        { x: 9, y: 100 },
      ]}
      width={dimensions.width}
      height={dimensions.height}
    />,
    <TreemapChart
      data={
        [
          { id: "1", value: 100, category: "Frontend", name: "React" },
          { id: "2", value: 80, category: "Backend", name: "Node.js" },
          { id: "3", value: 60, category: "Database", name: "MySQL" },
        ] as TreeMapData[]
      }
      width={dimensions.width}
      height={dimensions.height}
    />,
    <Hierarchy
      data={treeMapData2}
      width={dimensions.width}
      height={dimensions.height}
    />,
    <StackedAreaChart
      data={[
        { date: new Date("2020-01-01"), apples: 10, oranges: 20, bananas: 30 },
        { date: new Date("2020-01-02"), apples: 15, oranges: 25, bananas: 17 },
        { date: new Date("2020-01-03"), apples: 30, oranges: 30, bananas: 40 },
        { date: new Date("2020-01-04"), apples: 25, oranges: 35, bananas: 45 },
      ]}
      width={dimensions.width}
      height={dimensions.height}
    />,
    <StackedBarChart
      data={[
        { label: "A", value: 10 },
        { label: "B", value: 20 },
        { label: "C", value: 30 },
        { label: "D", value: 40 },
      ]}
      width={dimensions.width}
      height={dimensions.height}
    />,
    <StackedColumnChart
      data={[
        { label: "A", value: 10 },
        { label: "B", value: 20 },
        { label: "C", value: 30 },
        { label: "D", value: 40 },
      ]}
      width={dimensions.width}
      height={dimensions.height}
    />,
    <StackedLineChart
      data={[
        { label: "Point 1", value: 10, x: 10, y: 20 },
        { label: "Point 2", value: 20, x: 20, y: 30 },
        { label: "Point 3", value: 30, x: 30, y: 40 },
        { label: "Point 4", value: 40, x: 40, y: 50 },
      ]}
      width={dimensions.width}
      height={dimensions.height}
    />,
    <TimeSeriesChart
      data={monthlyHydrograph}
      width={dimensions.width}
      height={dimensions.height}
      xKey={"DateTime"}
      yKey={"value"}
    />,
    <WordCloudChart
      data={wordCloudData}
      width={dimensions.width}
      height={dimensions.height}
    />,
  ];

  const renderChart = (index: number) => {
    return (
      <ErrorBoundary fallback={<div className="chart-error">Error loading chart</div>}>
        <div className="chart-container" style={{ width: "100%", height: "100%" }}>
          {d3Components[index]}
        </div>
      </ErrorBoundary>
    );
  };

  return (
    <div className="w-full flex flex-col md:flex-row min-h-[calc(100vh-var(--navbar-height)-var(--footer-height))]">
      {/* Mobile Menu Toggle */}
      <button
        className="md:hidden px-4 py-2 mb-4 text-primary dark:text-primary-dark hover:bg-gray-100 dark:hover:bg-gray-800 rounded-lg transition-colors"
        onClick={() => setIsMobileMenuOpen(!isMobileMenuOpen)}
      >
        {isMobileMenuOpen ? "Hide Menu" : "Show Menu"}
      </button>

      {/* Left Panel (Sidebar) */}
      <div
        className={`
        w-full md:w-64
        bg-white dark:bg-gray-800
        border-b md:border-r border-gray-200 dark:border-gray-700
        ${isMobileMenuOpen ? "block" : "hidden"} md:block
        transition-all duration-300
      `}
      >
        <div className="p-4">
          {linkData.map((link) => (
            <details
              key={link.id}
              className={`
                mb-2 rounded-lg
                bg-gray-50 dark:bg-gray-900
                border border-gray-200 dark:border-gray-700
                ${
                  link.id === selectedLinkId
                    ? "ring-2 ring-primary dark:ring-primary-dark"
                    : ""
                }
              `}
              open={link.id === openDetailsId}
              onClick={(e) => e.preventDefault()}
            >
              <summary
                onClick={() => handleDetailsToggle(link.id)}
                className="px-4 py-2 cursor-pointer hover:bg-gray-100 dark:hover:bg-gray-800 transition-colors"
              >
                <span className="text-gray-800 dark:text-gray-200">
                  {link.title}
                </span>
              </summary>

              {link.id === openDetailsId && (
                <div className="p-4 border-t border-gray-200 dark:border-gray-700">
                  <button
                    onClick={(e) => {
                      e.stopPropagation();
                      handleLinkClick(link.id);
                    }}
                    className="w-full px-4 py-2 text-sm
                      bg-primary dark:bg-primary-dark
                      text-[var(--text-primary)] dark:text-gray-200
                      rounded-lg
                      hover:bg-primary-dark dark:hover:bg-primary
                      transition-colors
                      focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-primary dark:focus:ring-primary-dark"
                  >
                    View Content
                  </button>
                  {link.components && (
                    <div className="mt-4">
                      <h3 className="text-lg font-semibold">Components:</h3>
                      <ul>
                        {link.components.map((component, index) => (
                          <li key={index}>
                            <button
                              onClick={() => handleComponentClick(component)}
                              className="text-teams-blue hover:underline cursor-pointer"
                            >
                              {component}
                            </button>
                          </li>
                        ))}
                      </ul>
                    </div>
                  )}
                </div>
              )}
            </details>
          ))}
        </div>
      </div>

      {/* Right Panel (Content) */}
      <div
        className="flex-1 p-4 md:p-6 lg:p-8
        bg-white dark:bg-gray-800
        text-gray-800 dark:text-gray-200"
      >
        <article className="prose dark:prose-invert max-w-none">
          {selectedLink && typeof selectedLink.content === "string" ? (
            <div dangerouslySetInnerHTML={{ __html: selectedLink.content }} />
          ) : (
            <>{selectedLink?.content}</>
          )}
        </article>
      </div>

      {/* Modal for displaying components */}
      <Modal
        isOpen={isModalOpen}
        onDismiss={closeModal}
        responsiveMode={ResponsiveMode.small}
        isBlocking={false}
        isModeless={false}
        containerClassName="max-w-4xl mx-auto my-4 space-x-0 space-y-0 align-middle bg-primary dark:bg-primary-dark rounded-md shadow-lg text-primary dark:text-primary-dark"
      >
        <Toolbar aria-label="Component Toolbar" align={IAlign.right}>
          <div className="flex justify-between w-full">
            <h2 className="text-lg font-semibold text-info align-middle text-left truncate">
              Chart: {selectedComponent}
            </h2>
            <div className="flex space-x-2">
              {selectedComponent && (
                <button
                  className="flex items-center justify-center w-10 h-10 bg-teams-purple text-white rounded-full hover:bg-teams-purple-light active:bg-teams-purple-dark transition-all"
                  onClick={() =>
                    exportModalContent(selectedComponent || "not-found")
                  }
                  aria-label="Export Component"
                  title="Export Chart"
                >
                  <FaDownload className="w-5 h-5" />
                </button>
              )}
              {selectedComponent && (
                <button
                  className="flex items-center justify-center w-10 h-10 bg-danger text-white rounded-full hover:bg-danger-light active:bg-danger-dark transition-all"
                  onClick={closeModal}
                  aria-label="Close Modal"
                  title="Close Modal"
                >
                  <FaTimes className="w-5 h-5" />
                </button>
              )}
            </div>
          </div>
        </Toolbar>

        {selectedComponent && (
          <div className="py-4 px-1 bg-transparent dark:bg-inverted-light ">
            {d3Components.map((component, index) => (
              <div
                key={index}
                ref={
                  selectedComponent === component.type.name
                    ? componentRef
                    : null
                }
              >
                {selectedComponent === component.type.name ? (
                  <ErrorBoundary
                    fallback={
                      <div className="chart-error p-4 text-center">
                        <p>Failed to load chart</p>
                        <button
                          className="mt-2 px-3 py-1 rounded-md bg-primary text-white"
                          onClick={closeModal}
                        >
                          Close
                        </button>
                      </div>
                    }
                  >
                    {renderChart(index)}
                  </ErrorBoundary>
                ) : null}
              </div>
            ))}
          </div>
        )}
      </Modal>
    </div>
  );
};

export default HomePanels;
