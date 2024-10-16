// src/pages/Dashboard.tsx
import { Link } from "@fluentui/react";
import Wrapper from "../../layout/Wrapper/Wrapper";
import { DashboardHeaderBlock } from "./DashboardHeaderBlock";

const Dashboard = () => {
  return (
    <Wrapper header={<DashboardHeaderBlock/>}>
      
      <p>Welcome to the dashboard!</p>

      <div className="p-8">
        <h1 className="text-2xl font-bold mb-4">Sitemap</h1>
        <ul>
          <li className="text-lg"><a
            href="/"
            target="_self"
            rel="noopener noreferrer"
          >
            Home
          </a></li>
          <li className="text-lg">
            <Link to="/about">About</Link>
          </li>
          <li className="text-lg">
            <Link href="/manage-sitemap-content" target="_self">Sitemap Page</Link>
          </li>
        </ul>
      </div>

    </Wrapper>
  );
};

export default Dashboard;
