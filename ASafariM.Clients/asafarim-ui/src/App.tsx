import { Routes, Route, useLocation, Navigate } from "react-router-dom";
import { Suspense, useEffect, lazy, useState } from "react";
import React from "react";
import { useAuth } from "./contexts/AuthContext";
import { getAllMdFiles } from "./utils/mdFilesUtils";
import { trackPageView } from "./services/analyticsService";
import { logger } from "@/utils/logger";

// Lazy load components for better performance
const PrivateRoute = lazy(() => import("./components/PrivateRoute"));
const About = lazy(() => import("./pages/AboutMe/About"));
const Dashboard = lazy(() => import("./pages/Dashboard/DashboardPage"));
const SitemapPage = lazy(() => import("./pages/Sitemap/SitemapPage"));
const NotFound = lazy(() => import("./components/NotFound"));
const Home = lazy(() => import("./pages/Home/HomePage"));
const AkkodisTargetedResume = lazy(() => import("./pages/AboutMe/TailoredCV/Akkodis"));
const DelCard = lazy(() => import("./components/Containers/Card/DelCard"));
const ProjectHome = lazy(() => import("./pages/Project/Index"));
const PostDetail = lazy(() => import("./pages/Blog/PostDetail"));
const LogoutPage = lazy(() => import("./pages/Accountpage/LogoutPage"));
const Register = lazy(() => import("./pages/Accountpage/Register"));
const LoginPage = lazy(() => import("./pages/Accountpage/LoginPage"));
const ForgotPasswordPage = lazy(() => import("./pages/Accountpage/ForgotPasswordPage"));
const ResetPasswordPage = lazy(() => import("./pages/Accountpage/ResetPasswordPage"));
const UsersList = lazy(() => import("./pages/User/UsersList"));
const CreateUser = lazy(() => import("./pages/User/CreateUser"));
const EditUser = lazy(() => import("./pages/User/EditUser"));
const Footer = lazy(() => import("./layout/Footer/Footer"));
const UserProfile = lazy(() => import("./pages/User/UserProfile"));
const Layout = lazy(() => import("./layout/Layout"));
const Contact = lazy(() => import("./pages/Contact"));
const MarkdownPage = lazy(() => import("./components/MarkdownPage/MarkdownPage"));
const AccountSettings = lazy(() => import("./pages/Accountpage/AccountSettings"));
const TimeoutNotification = lazy(() => import("./components/TimeoutNotification").then(module => ({ default: module.TimeoutNotification })));
const ConnectionStatus = lazy(() => import("./components/ConnectionStatus").then(module => ({ default: module.ConnectionStatus })));
const AddProject = lazy(() => import("./pages/Project/AddProject"));
const ViewProject = lazy(() => import("./pages/Project/ViewProject"));
const AccessDenied = lazy(() => import("./pages/AccessDenied"));
const CreateMarkdownFile = lazy(() => import("./components/MarkdownPage/CreateMarkdownFile"));
const AddCategoryForm = lazy(() => import("./components/crud/AddCategoryForm"));
const AddTopicForm = lazy(() => import("./components/crud/AddTopicForm"));
const AddPostForm = lazy(() => import("./pages/Blog/AddPostForm"));
const EditCategoryForm = lazy(() => import("./components/crud/EditCategoryForm"));
const EditTopicForm = lazy(() => import("./components/crud/EditTopicForm"));
const EditPostForm = lazy(() => import("./pages/Blog/EditPostForm"));
const EditSitemapItemForm = lazy(() => import("./components/crud/EditSitemapItemForm"));
const AddSitemapItemForm = lazy(() => import("./components/crud/AddSitemapItemForm"));
const DeleteForm = lazy(() => import("./components/crud/DeleteForm"));
const AddTagForm = lazy(() => import("./components/crud/AddTagForm"));
const EditTagForm = lazy(() => import("./components/crud/EditTagForm"));
const PostsList = lazy(() => import("./pages/Blog/PostsList"));
const CreatePost = lazy(() => import("./pages/Blog/CreatePost"));
const HealthCheck = lazy(() => import("./pages/HealthCheck/HealthCheck"));
const ViewUser = lazy(() => import("./pages/User/ViewUser"));
const NetworkSettings = lazy(() => import("./pages/Settings/NetworkSettings"));
const EditProject = lazy(() => import("./pages/Project/EditProject"));
const UnderConstruction = lazy(() => import("./pages/UnderConstruction"));
const AnalyticsPage = lazy(() => import("./pages/Analytics/AnalyticsPage"));
const ActivityPage = lazy(() => import("./pages/Activity/ActivityPage"));
const NavbarDemo = lazy(() => import("./pages/Demo/NavbarDemo"));
import {
  ConsentProvider,
  ConsentBanner,
  ConsentModal,
  useConsent,
} from "@asafarim/react-privacy-consent";
import { globalConsentConfig } from "./config/consentConfig";
import "@asafarim/react-privacy-consent/styles.css";
import "@asafarim/react-themes/styles.css"; // Optional base styles
import { IMenuItem } from "./interfaces/IMenuItem";

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
  const location = useLocation();
  const [mds, setMds] = useState<{
    currentProjects: IMenuItem;
    essentialInsights: IMenuItem;
    legalDocs: IMenuItem;
    changelogs: IMenuItem;
    techDocs: IMenuItem;
    projects: IMenuItem;
  } | null>(null);
  const [isLoading, setIsLoading] = useState(true);

  // Move heavy operations out of render cycle
  useEffect(() => {
    const loadMdFiles = async () => {
      try {
        const mdFiles = await getAllMdFiles();
        setMds(mdFiles);
      } catch (error) {
        logger.error('Failed to load markdown files:', error);
      } finally {
        setIsLoading(false);
      }
    };
    loadMdFiles();
  }, []);

  // Track page views when route changes
  useEffect(() => {
    trackPageView(location.pathname, document.title);
  }, [location]);

  useEffect(() => {
    if (!authenticated || authenticatedUser?.isDeleted) {
      logger.log("User is not authenticated or deleted");
    }
  }, [authenticated, authenticatedUser]);

  const dropdownItems = mds ? [
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
  ] : [];

  // Show loading state while markdown files are being loaded
  if (isLoading) {
    return (
      <div className="min-h-screen bg-default text-default flex items-center justify-center">
        <div className="text-center">
          <div className="animate-spin rounded-full h-32 w-32 border-b-2 border-primary mx-auto mb-4"></div>
          <p className="text-lg">Loading...</p>
        </div>
      </div>
    );
  }
  // const pathSegments = ['categories', 'topics', 'sections', 'chapters', 'slug'];
  return (
      <ConsentProvider config={globalConsentConfig}>
        <div className="min-h-screen bg-default text-default">
          <Routes>
            <Route path="/" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <Home />
              </Suspense>
            } />
            <Route
              path="/create-markdown"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
              <Route index element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <ProjectHome key={Math.random()} />
                </Suspense>
              } />

              {/* Route for adding a new project */}
              <Route
                path="add"
                element={
                  <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                    <AddProject />
                  </Suspense>
                }
              />

              {/* Route for viewing a specific project */}
              <Route
                path=":id"
                element={
                  <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                    <ViewProject />
                  </Suspense>
                }
              />

              {/* Route for editing a project */}
              <Route
                path="edit/:id"
                element={
                  <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                    <EditProject />
                  </Suspense>
                }
              />

              {/* Route for deleting a project */}
              <Route
                path="del/:id"
                element={
                  <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
                    <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
                    <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
                    <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
                    <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
                    <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
                    <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
                    <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
                    <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
                    <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
                    <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
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
            <Route path="/posts/:slug" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <PostDetail />
              </Suspense>
            } />
            <Route
              path="/dashboard"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <PrivateRoute requireAdmin={true}>
                    <Dashboard />
                  </PrivateRoute>
                </Suspense>
              }
            />

            <Route
              path="/analytics"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <PrivateRoute requireAdmin={true}>
                    <AnalyticsPage />
                  </PrivateRoute>
                </Suspense>
              }
            />

            <Route path="/[...notfound]" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <NotFound />
              </Suspense>
            } />
            <Route path="/logout" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <LogoutPage />
              </Suspense>
            } />
            {token && (
              <>
                <Route
                  path="/about/akkodis-targeted-resume"
                  element={
                    <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                      <AkkodisTargetedResume />
                    </Suspense>
                  }
                />
              </>
            )}
            <Route path="/contact" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <Contact />
              </Suspense>
            } />
            <Route path="/about" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <About />
              </Suspense>
            } />
            <Route
              path="/user-account-settings"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <PrivateRoute>
                    <AccountSettings />
                  </PrivateRoute>
                </Suspense>
              }
            />
            <Route
              path="/user-profile"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <PrivateRoute>
                    <UserProfile />
                  </PrivateRoute>
                </Suspense>
              }
            />
            <Route
              path="/manage-sitemap-content"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <PrivateRoute requireAdmin>
                    <SitemapPage />
                  </PrivateRoute>
                </Suspense>
              }
            />
            <Route path="/login" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <LoginPage />
              </Suspense>
            } />
            <Route path="/register" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <Register />
              </Suspense>
            } />
            <Route path="/forgot-password" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <ForgotPasswordPage />
              </Suspense>
            } />
            <Route path="/reset-password" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <ResetPasswordPage />
              </Suspense>
            } />

            <Route
              path="/users"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <PrivateRoute>
                    <UsersList />
                  </PrivateRoute>
                </Suspense>
              }
            />
            <Route path="/users/create" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <CreateUser />
              </Suspense>
            } />
            <Route
              path="/users/edit/:id"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <PrivateRoute requireAdmin>
                    <EditUser />
                  </PrivateRoute>
                </Suspense>
              }
            />
            <Route
              path="/users/view/:id"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <PrivateRoute requireAdmin>
                    <ViewUser />
                  </PrivateRoute>
                </Suspense>
              }
            />
            {/** Add route for crud operations for dynamic models to cover all use cases regarding: Tags, Categories, Topics, Projects, Posts, SitemapItems */}
            <Route path="/tags/add" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <AddTagForm />
              </Suspense>
            } />
            <Route path="/tags/edit/:id" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <EditTagForm />
              </Suspense>
            } />
            <Route
              path="/tags/delete/:id"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <DeleteForm entity="tags" />
                </Suspense>
              }
            />
            <Route path="/categories/add" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <AddCategoryForm />
              </Suspense>
            } />
            <Route path="/categories/edit/:id" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <EditCategoryForm />
              </Suspense>
            } />
            <Route
              path="/categories/delete/:id"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <DeleteForm entity="categories" />
                </Suspense>
              }
            />
            <Route path="/topics/add" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <AddTopicForm />
              </Suspense>
            } />
            <Route path="/topics/edit/:id" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <EditTopicForm />
              </Suspense>
            } />
            <Route
              path="/topics/delete/:id"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <DeleteForm entity="topics" />
                </Suspense>
              }
            />
            <Route path="/posts" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <PostsList />
              </Suspense>
            } />
            <Route path="/posts/create" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <CreatePost />
              </Suspense>
            } />
            <Route path="/posts/add" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <AddPostForm />
              </Suspense>
            } />
            <Route path="/posts/edit/:id" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <EditPostForm />
              </Suspense>
            } />
            <Route
              path="/posts/delete/:id"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <DeleteForm entity="posts" />
                </Suspense>
              }
            />
            <Route path="/sitemap-items/add" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <AddSitemapItemForm />
              </Suspense>
            } />
            <Route
              path="/sitemap-items/edit/:id"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <EditSitemapItemForm />
                </Suspense>
              }
            />
            <Route
              path="/sitemap-items/delete/:id"
              element={
                <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                  <DeleteForm entity="sitemapitems" />
                </Suspense>
              }
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
            <Route path="/system-health" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <HealthCheck />
              </Suspense>
            } />
            <Route path="/network-settings" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <NetworkSettings />
              </Suspense>
            } />
            <Route path="/activity" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <ActivityPage />
              </Suspense>
            } />
            <Route path="/navbar-demo" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <NavbarDemo />
              </Suspense>
            } />
            <Route path="/access-denied" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <AccessDenied />
              </Suspense>
            } />
            <Route path="*" element={
              <Suspense fallback={<div className="min-h-screen flex items-center justify-center"><div className="animate-spin rounded-full h-16 w-16 border-b-2 border-primary"></div></div>}>
                <NotFound />
              </Suspense>
            } />
          </Routes>

          {/* Timeout and Connection Management Components */}
          <Suspense fallback={null}>
            <TimeoutNotification />
          </Suspense>
          <Suspense fallback={null}>
            <ConnectionStatus
              showDetails={false}
              className="fixed bottom-4 right-4 z-50"
            />
          </Suspense>
        </div>
        <Suspense fallback={null}>
          <ConsentBanner />
        </Suspense>
        <Suspense fallback={null}>
          <ConsentModalWrapper />
        </Suspense>
      </ConsentProvider>
  );
}

export default App;
