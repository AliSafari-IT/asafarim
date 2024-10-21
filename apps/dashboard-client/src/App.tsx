// src/App.tsx
import {
  Routes,
  Route,
  Navigate,
} from "react-router-dom";
import PrivateRoute from "./components/PrivateRoute";
import About from "./pages/AboutMe/About";
import Contact from "./pages/Contact";
import Dashboard from "./pages/Dashboard/DashboardPage";
import LoginPage from "./pages/Login/LoginPage";
import LogoutPage from "./pages/LogoutPage";
import SitemapPage from "./pages/Sitemap/SitemapPage";
import NotFound from "./components/NotFound";
import Home from "./pages/Home/HomePage";
import PostDetail from "./pages/Post/PostDetail";
import AkkodisTargetedResume from "./pages/AboutMe/TailoredCV/Akkodis";
import './styles/custom.css';
import { useEffect, useState } from "react";
 import { useTheme } from "./hooks/useTheme";
function App() {
  const [theme] = useState(useTheme().theme);

  useEffect(() => {
    document.body.setAttribute('data-theme', theme); // Apply the theme
    localStorage.setItem('theme', theme);
    // Log the theme
    console.log('Theme is', theme);
  }, [theme]);
  
  // const { theme } = useTheme();
  useEffect(() => {
    document.body.setAttribute('data-theme', theme); 
  }, [theme]);

  return (
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="/posts/:slug" element={<PostDetail />} />
      <Route path="/about" element={<About />} />
      <Route path="/about/akkodis-targeted-resume" element={<AkkodisTargetedResume />} />
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
