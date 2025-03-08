import React from "react";
import Wrapper from "../../layout/Wrapper/Wrapper";
import { DashboardHeaderBlock } from "./DashboardHeaderBlock";
import {
  FluentProvider,
  Link,
  webDarkTheme,
  webLightTheme,
} from "@fluentui/react-components";
import CardContainer from "../../components/Containers/Card/CardContainer";
import { useTheme } from "@/contexts/ThemeContext";

const Dashboard: React.FC = () => {
  const { theme } = useTheme();
  const currentTheme = theme === "dark" ? webDarkTheme : webLightTheme;

  return (
    <Wrapper header={<DashboardHeaderBlock />}>
      <FluentProvider theme={currentTheme}>
        <CardContainer />
      </FluentProvider>

      {/* Button Row */}
      <div className="flex flex-col sm:flex-row items-center justify-center gap-4 mt-6">
        <Link href="/projects">
          <button
            className="
              px-5 py-3 
              font-bold 
              rounded-md 
              shadow-md 
              transition 
              duration-300 
              transform 
              bg-[var(--primary)] 
              text-[var(--text-inverted)] 
              hover:bg-[var(--primary-dark)] 
              hover:scale-105
              focus:outline-none 
              focus:ring-2 
              focus:ring-[var(--accent)]
            "
          >
            Discover Projects
          </button>
        </Link>

        <Link href="/users">
          <button
            className="
              px-5 py-3 
              font-bold 
              rounded-md 
              shadow-md 
              transition 
              duration-300 
              transform 
              bg-[var(--secondary)] 
              text-[var(--text-inverted)] 
              hover:bg-[var(--secondary-dark)] 
              hover:scale-105
              focus:outline-none 
              focus:ring-2 
              focus:ring-[var(--accent)]
            "
          >
            Manage Users
          </button>
        </Link>

        <Link href="/blog">
          <button
            className="
              px-5 py-3 
              font-bold 
              rounded-md 
              shadow-md 
              transition 
              duration-300 
              transform 
              bg-[var(--tertiary)] 
              text-[var(--text-inverted)] 
              hover:bg-[var(--tertiary-dark)] 
              hover:scale-105
              focus:outline-none 
              focus:ring-2 
              focus:ring-[var(--accent)]
            "
          >
            Read Our Blog
          </button>
        </Link>

        <Link href="/contact-asafarim">
          <button
            className="
              px-5 py-3 
              font-bold 
              rounded-md 
              shadow-md 
              transition 
              duration-300 
              transform 
              bg-[var(--accent)] 
              text-[var(--text-inverted)] 
              hover:bg-[var(--accent-dark)] 
              hover:scale-105
              focus:outline-none 
              focus:ring-2 
              focus:ring-[var(--accent)]
            "
          >
            Get in Touch
          </button>
        </Link>

        <Link href="/changelogs">
          <button
            className="
              px-5 py-3 
              font-bold 
              rounded-md 
              shadow-md 
              transition 
              duration-300 
              transform 
              bg-[var(--info)] 
              text-[var(--text-inverted)] 
              hover:bg-[var(--info-dark)] 
              hover:scale-105
              focus:outline-none 
              focus:ring-2 
              focus:ring-[var(--accent)]
            "
          >
            View Changelogs
          </button>
        </Link>
        
      </div>
    </Wrapper>
  );
};

export default Dashboard;
