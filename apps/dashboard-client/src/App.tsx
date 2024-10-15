// src/App.tsx
import {
  Routes,
  Route,
  Navigate,
} from "react-router-dom";
import PrivateRoute from "./components/PrivateRoute";
import About from "./pages/AboutMe/About";
import Contact from "./pages/Contact";
import Dashboard from "./pages/Dashboard";
import Home from "./pages/Home";
import LoginPage from "./pages/LoginPage";
import LogoutPage from "./pages/LogoutPage";
import SitemapPage from "./pages/Sitemap/SitemapPage";
import NotFound from "./components/NotFound";
import { initializeIcons } from '@fluentui/react/lib/Icons';
// Initialize Fluent UI icons
initializeIcons();

function App() {
  return (
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="/about" element={<About />} />
      <Route path="/contact" element={<Contact />} />

      <Route
        path="/dashboard"
        element={
          <PrivateRoute>
            <Dashboard />
          </PrivateRoute>
        }
      />
      <Route
        path="/manage-sitemap-content"
        element={
          <PrivateRoute>
            <SitemapPage />
          </PrivateRoute>
        }
      />

      <Route path="/login" element={<LoginPage />} />
      <Route
        path="/logout"
        element={
          <PrivateRoute>
            <LogoutPage />
          </PrivateRoute>
        }
      />

      <Route
        path="/health-ui"
        element={<Navigate to="/health-ui" />}
      />
      {/* Catch-all route */}
      <Route path="*" element={<NotFound />} />
    </Routes>
  );
}

export default App;
