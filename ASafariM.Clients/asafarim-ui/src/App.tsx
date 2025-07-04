import { Routes, Route, useLocation, Navigate } from "react-router-dom";
import PrivateRoute from "./components/PrivateRoute";
import About from "./pages/AboutMe/About";
import Dashboard from "./pages/Dashboard/DashboardPage";
import SitemapPage from "./pages/Sitemap/SitemapPage";
import NotFound from "./components/NotFound";
import Home from "./pages/Home/HomePage";
import AkkodisTargetedResume from "./pages/AboutMe/TailoredCV/Akkodis";
import DelCard from "./components/Containers/Card/DelCard";
import ProjectHome from "./pages/Project/Index";
import PostDetail from "./pages/Blog/PostDetail";
import LogoutPage from "./pages/Accountpage/LogoutPage";
import Register from "./pages/Accountpage/Register";
import LoginPage from "./pages/Accountpage/LoginPage";
import ForgotPasswordPage from "./pages/Accountpage/ForgotPasswordPage";
import ResetPasswordPage from "./pages/Accountpage/ResetPasswordPage";
import UsersList from "./pages/User/UsersList";
import CreateUser from "./pages/User/CreateUser";
import EditUser from "./pages/User/EditUser";
import Footer from "./layout/Footer/Footer";
import UserProfile from "./pages/User/UserProfile";
import { Suspense, useEffect } from "react";
import Layout from "./layout/Layout";
import Contact from "./pages/Contact";
import MarkdownPage from "./components/MarkdownPage/MarkdownPage";
import AccountSettings from "./pages/Accountpage/AccountSettings";
import { getAllMdFiles } from "./utils/mdFilesUtils";
import { useAuth } from "./contexts/AuthContext";
import { TimeoutNotification } from "./components/TimeoutNotification";
import { ConnectionStatus } from "./components/ConnectionStatus";
import React from "react";
import AddProject from "./pages/Project/AddProject";
import ViewProject from "./pages/Project/ViewProject";
import AccessDenied from "./pages/AccessDenied";
import CreateMarkdownFile from "./components/MarkdownPage/CreateMarkdownFile";
import AddCategoryForm from "./components/crud/AddCategoryForm";
import AddTopicForm from "./components/crud/AddTopicForm";
import AddPostForm from "./pages/Blog/AddPostForm";
import EditCategoryForm from "./components/crud/EditCategoryForm";
import EditTopicForm from "./components/crud/EditTopicForm";
import EditPostForm from "./pages/Blog/EditPostForm";
import EditSitemapItemForm from "./components/crud/EditSitemapItemForm";
import AddSitemapItemForm from "./components/crud/AddSitemapItemForm";
import DeleteForm from "./components/crud/DeleteForm";
import AddTagForm from "./components/crud/AddTagForm";
import EditTagForm from "./components/crud/EditTagForm";
import PostsList from "./pages/Blog/PostsList";
import CreatePost from "./pages/Blog/CreatePost";
import HealthCheck from "./pages/HealthCheck/HealthCheck";
import ViewUser from "./pages/User/ViewUser";
import NetworkSettings from "./pages/Settings/NetworkSettings";
import EditProject from "./pages/Project/EditProject";
import UnderConstruction from "./pages/UnderConstruction";
import { trackPageView } from "./services/analyticsService";
import AnalyticsPage from "./pages/Analytics/AnalyticsPage";
import ActivityPage from "./pages/Activity/ActivityPage";
import NavbarDemo from "./pages/Demo/NavbarDemo";
import { logger } from "@/utils/logger";
import {
  ConsentProvider,
  ConsentBanner,
  ConsentModal,
  useConsent,
} from "@asafarim/react-privacy-consent";
import { globalConsentConfig } from "./config/consentConfig";
import "@asafarim/react-privacy-consent/styles.css";
import "@asafarim/react-themes/styles.css"; // Optional base styles

// const userUrl = API_URL + '/users';

// Wrapper component to connect ConsentModal to consent context
function ConsentModalWrapper() {
  const { isPreferencesVisible, hidePreferences } = useConsent();

  return (
    <ConsentModal isOpen={isPreferencesVisible} onClose={hidePreferences} />
  );
}

function App() {
  const { authenticatedUser, authenticated, token } = useAuth();
  const mds = getAllMdFiles();
  const location = useLocation();

  // Track page views when route changes
  useEffect(() => {
    trackPageView(location.pathname, document.title);
  }, [location]);

  useEffect(() => {
    if (!authenticated || authenticatedUser?.isDeleted) {
      logger.log("User is not authenticated or deleted");
    }
  }, [authenticated, authenticatedUser]);

  const dropdownItems = [
    {
      name: "legal-docs",
      label: "Legal Docs",
      data: mds.legalDocs,
      baseUrl: "/legal-docs",
      description: "Legal Documentation",
    },
    {
      name: "changelogs",
      label: "Changelogs",
      data: mds.changelogs,
      baseUrl: "/changelogs",
      description: "Changelogs",
    },
    {
      name: "tech-docs",
      label: "Tech Docs",
      data: mds.techDocs,
      baseUrl: "/tech-docs",
      description: "Technical Documentation",
    },
    {
      name: "essential-insights",
      label: "Essential Insights",
      data: mds.essentialInsights,
      baseUrl: "/essential-insights",
      description: "Essential Insights Documentation",
    },
    {
      name: "projects",
      label: "Projects",
      data: mds.projects,
      baseUrl: "/projects",
      description: "Project Documentation",
    },
    {
      name: "current-projects",
      label: "Current Projects",
      data: mds.currentProjects,
      baseUrl: "/current-projects",
      description: "Current Projects Documentation",
    },
  ];
  // const pathSegments = ['categories', 'topics', 'sections', 'chapters', 'slug'];
  return (
      <ConsentProvider config={globalConsentConfig}>
        <div className="min-h-screen bg-default text-default">
          <Routes>
            <Route path="/" element={<Home />} />
            <Route
              path="/create-markdown"
              element={
                <Suspense fallback={<div>Loading...</div>}>
                  <PrivateRoute>
                    <Layout header={<></>} footer={<Footer />}>
                      <CreateMarkdownFile />
                    </Layout>
                  </PrivateRoute>
                </Suspense>
              }
            />
            <Route path="/projects">
              {/* Default route for the project home page */}
              <Route index element={<ProjectHome key={Math.random()} />} />

              {/* Route for adding a new project */}
              <Route
                path="add"
                element={
                  <Suspense fallback={<div>Loading...</div>}>
                    <AddProject />
                  </Suspense>
                }
              />

              {/* Route for viewing a specific project */}
              <Route
                path=":id"
                element={
                  <Suspense fallback={<div>Loading...</div>}>
                    <ViewProject />
                  </Suspense>
                }
              />

              {/* Route for editing a project */}
              <Route
                path="edit/:id"
                element={
                  <Suspense fallback={<div>Loading...</div>}>
                    <EditProject />
                  </Suspense>
                }
              />

              {/* Route for deleting a project */}
              <Route
                path="del/:id"
                element={
                  <Suspense fallback={<div>Loading...</div>}>
                    <DelCard />
                  </Suspense>
                }
              />
            </Route>

            {dropdownItems.map((item) => (
              <React.Fragment key={item.name}>
                {/* Route for categories */}
                <Route
                  path={`${item.baseUrl}/:categories`}
                  element={
                    <Suspense fallback={<div>Loading...</div>}>
                      <MarkdownPage
                        data={item.data}
                        title={item.label}
                        description={item.description}
                        baseUrl={item.baseUrl}
                      />
                    </Suspense>
                  }
                />

                {/* Route for topics within categories */}
                <Route
                  path={`${item.baseUrl}/:categories/:topics`}
                  element={
                    <Suspense fallback={<div>Loading...</div>}>
                      <MarkdownPage
                        data={item.data}
                        title={item.label}
                        description={item.description}
                        baseUrl={item.baseUrl}
                      />
                    </Suspense>
                  }
                />

                {/* Route for sections within topics */}
                <Route
                  path={`${item.baseUrl}/:categories/:topics/:sections`}
                  element={
                    <Suspense fallback={<div>Loading...</div>}>
                      <MarkdownPage
                        data={item.data}
                        title={item.label}
                        description={item.description}
                        baseUrl={item.baseUrl}
                      />
                    </Suspense>
                  }
                />

                {/* Route for chapters within sections */}
                <Route
                  path={`${item.baseUrl}/:categories/:topics/:sections/:chapters`}
                  element={
                    <Suspense fallback={<div>Loading...</div>}>
                      <MarkdownPage
                        data={item.data}
                        title={item.label}
                        description={item.description}
                        baseUrl={item.baseUrl}
                      />
                    </Suspense>
                  }
                />

                {/* Route for slugs that can be at any level */}
                <Route
                  path={`${item.baseUrl}/:categories/:topics/:sections/:chapters/:slug`}
                  element={
                    <Suspense fallback={<div>Loading...</div>}>
                      <MarkdownPage
                        data={item.data}
                        title={item.label}
                        description={item.description}
                        baseUrl={item.baseUrl}
                      />
                    </Suspense>
                  }
                />
                <Route
                  path={`${item.baseUrl}/:categories/:topics/:sections/:slug`}
                  element={
                    <Suspense fallback={<div>Loading...</div>}>
                      <MarkdownPage
                        data={item.data}
                        title={item.label}
                        description={item.description}
                        baseUrl={item.baseUrl}
                      />
                    </Suspense>
                  }
                />
                <Route
                  path={`${item.baseUrl}/:categories/:topics/:slug`}
                  element={
                    <Suspense fallback={<div>Loading...</div>}>
                      <MarkdownPage
                        data={item.data}
                        title={item.label}
                        description={item.description}
                        baseUrl={item.baseUrl}
                      />
                    </Suspense>
                  }
                />
                <Route
                  path={`${item.baseUrl}/:categories/:slug`}
                  element={
                    <Suspense fallback={<div>Loading...</div>}>
                      <MarkdownPage
                        data={item.data}
                        title={item.label}
                        description={item.description}
                        baseUrl={item.baseUrl}
                      />
                    </Suspense>
                  }
                />
                <Route
                  path={`${item.baseUrl}/:slug`}
                  element={
                    <Suspense fallback={<div>Loading...</div>}>
                      <MarkdownPage
                        data={item.data}
                        title={item.label}
                        description={item.description}
                        baseUrl={item.baseUrl}
                      />
                    </Suspense>
                  }
                />
                <Route
                  path={`${item.baseUrl}`}
                  element={
                    <Suspense fallback={<div>Loading...</div>}>
                      <MarkdownPage
                        data={item.data}
                        title={item.label}
                        description={item.description}
                        baseUrl={item.baseUrl}
                      />
                    </Suspense>
                  }
                />
              </React.Fragment>
            ))}
            <Route path="/posts/:slug" element={<PostDetail />} />
            <Route
              path="/dashboard"
              element={
                <PrivateRoute requireAdmin={true}>
                  <Dashboard />
                </PrivateRoute>
              }
            />

            <Route
              path="/analytics"
              element={
                <PrivateRoute requireAdmin={true}>
                  <AnalyticsPage />
                </PrivateRoute>
              }
            />

            <Route path="/[...notfound]" element={<NotFound />} />
            <Route path="/logout" element={<LogoutPage />} />
            {token && (
              <>
                <Route
                  path="/about/akkodis-targeted-resume"
                  element={<AkkodisTargetedResume />}
                />
              </>
            )}
            <Route path="/contact" element={<Contact />} />
            <Route path="/about" element={<About />} />
            <Route
              path="/user-account-settings"
              element={
                <PrivateRoute>
                  <AccountSettings />
                </PrivateRoute>
              }
            />
            <Route
              path="/user-profile"
              element={
                <PrivateRoute>
                  <UserProfile />
                </PrivateRoute>
              }
            />
            <Route
              path="/manage-sitemap-content"
              element={
                <PrivateRoute requireAdmin>
                  <SitemapPage />
                </PrivateRoute>
              }
            />
            <Route path="/login" element={<LoginPage />} />
            <Route path="/register" element={<Register />} />
            <Route path="/forgot-password" element={<ForgotPasswordPage />} />
            <Route path="/reset-password" element={<ResetPasswordPage />} />

            <Route
              path="/users"
              element={
                <PrivateRoute>
                  <UsersList />
                </PrivateRoute>
              }
            />
            <Route path="/users/create" element={<CreateUser />} />
            <Route
              path="/users/edit/:id"
              element={
                <Suspense fallback={<div>Loading...</div>}>
                  <PrivateRoute requireAdmin>
                    <EditUser />
                  </PrivateRoute>
                </Suspense>
              }
            />
            <Route
              path="/users/view/:id"
              element={
                <Suspense fallback={<div>Loading...</div>}>
                  <PrivateRoute requireAdmin>
                    <ViewUser />
                  </PrivateRoute>
                </Suspense>
              }
            />
            {/** Add route for crud operations for dynamic models to cover all use cases regarding: Tags, Categories, Topics, Projects, Posts, SitemapItems */}
            <Route path="/tags/add" element={<AddTagForm />} />
            <Route path="/tags/edit/:id" element={<EditTagForm />} />
            <Route
              path="/tags/delete/:id"
              element={<DeleteForm entity="tags" />}
            />
            <Route path="/categories/add" element={<AddCategoryForm />} />
            <Route path="/categories/edit/:id" element={<EditCategoryForm />} />
            <Route
              path="/categories/delete/:id"
              element={<DeleteForm entity="categories" />}
            />
            <Route path="/topics/add" element={<AddTopicForm />} />
            <Route path="/topics/edit/:id" element={<EditTopicForm />} />
            <Route
              path="/topics/delete/:id"
              element={<DeleteForm entity="topics" />}
            />
            <Route path="/posts" element={<PostsList />} />
            <Route path="/posts/create" element={<CreatePost />} />
            <Route path="/posts/add" element={<AddPostForm />} />
            <Route path="/posts/edit/:id" element={<EditPostForm />} />
            <Route
              path="/posts/delete/:id"
              element={<DeleteForm entity="posts" />}
            />
            <Route path="/sitemap-items/add" element={<AddSitemapItemForm />} />
            <Route
              path="/sitemap-items/edit/:id"
              element={<EditSitemapItemForm />}
            />
            <Route
              path="/sitemap-items/delete/:id"
              element={<DeleteForm entity="sitemapitems" />}
            />
            {/* redirect  /blog to blog.asafarim.com */}
            <Route
              path="/blog"
              element={<Navigate to="https://blog.asafarim.com" replace />}
            />
            {/* redirect  /community to community.asafarim.com */}
            <Route
              path="/community"
              element={
                <UnderConstruction
                  title="Our Community is Under Construction"
                  constructionTips={[
                    `We're working hard to build a community platform that will provide a space for 
                  technical discussions, sharing knowledge, and fostering a community of like-minded 
                  individuals.`,
                    "We're building a comment system for community discussions.",
                    "Expect categories for different technology domains.",
                    "Subscribe feature coming soon to get notified of new posts.",
                    "Author profiles will showcase expertise and credentials.",
                    "Dark mode support is being implemented for comfortable reading.",
                    "Code snippets with syntax highlighting are on the way!",
                    "Search functionality will help you find relevant content quickly.",
                  ]}
                  description="We're working hard to build a new and improved community. Check back soon!"
                  bodyText={`Our team is working hard to create a community platform that will provide a space for 
              technical discussions, sharing knowledge, and fostering a community of like-minded 
              individuals. We appreciate your patience 
              as we construct this new section of our website.`}
                />
              }
            />
            <Route path="/system-health" element={<HealthCheck />} />
            <Route path="/network-settings" element={<NetworkSettings />} />
            <Route path="/activity" element={<ActivityPage />} />
            <Route path="/navbar-demo" element={<NavbarDemo />} />
            <Route path="/access-denied" element={<AccessDenied />} />
            <Route path="*" element={<NotFound />} />
          </Routes>

          {/* Timeout and Connection Management Components */}
          <TimeoutNotification />
          <ConnectionStatus
            showDetails={false}
            className="fixed bottom-4 right-4 z-50"
          />
        </div>
        <ConsentBanner />
        <ConsentModalWrapper />
      </ConsentProvider>
  );
}

export default App;
