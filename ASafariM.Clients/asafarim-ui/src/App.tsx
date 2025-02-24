import {
  Routes,
  Route,
} from "react-router-dom";
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
import UsersList from "./pages/User/UsersList";
import CreateUser from "./pages/User/CreateUser";
import EditUser from "./pages/User/EditUser";
import Footer from "./layout/Footer/Footer";
import UserProfile from "./pages/User/UserProfile";
import { Suspense, useEffect } from "react";
import Layout from "./layout/Layout";
//import UserAccountSettings from "./pages/User/UserAccountSettings";
import Contact from "./pages/Contact";
import MarkdownPage from "./components/MarkdownPage/MarkdownPage";
import { ThemeProvider } from './contexts/ThemeContext';
import AccountSettings from "./pages/Accountpage/AccountSettings";
import { getAllMdFiles } from "./utils/mdFilesUtils";
import useAuth from "./hooks/useAuth";
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
import EditProject from "./pages/Project/EditProject";

// const userUrl = API_URL + '/users';


function App() {
  const { authenticatedUser, authenticated, token } = useAuth();
  const mds = getAllMdFiles();

  useEffect(() => {
    if (!authenticated || authenticatedUser.isDeleted) {
      console.log('User is not authenticated or deleted');
    }
  }, [authenticated, authenticatedUser]);


  const dropdownItems = [
    { name: 'legal-docs', label: 'Legal Docs', data: mds.legalDocs, baseUrl: '/legal-docs', description: 'Legal Documentation' },
    { name: 'changelogs', label: 'Changelogs', data: mds.changelogs, baseUrl: '/changelogs', description: 'Changelogs' },
    { name: 'tech-docs', label: 'Tech Docs', data: mds.techDocs, baseUrl: '/tech-docs', description: 'Technical Documentation' },
    { name: 'essential-insights', label: 'Essential Insights', data: mds.essentialInsights, baseUrl: '/essential-insights', description: 'Essential Insights Documentation' },
    { name: 'projects', label: 'Projects', data: mds.projects, baseUrl: '/projects', description: 'Project Documentation' },
  ];
  // const pathSegments = ['categories', 'topics', 'sections', 'chapters', 'slug'];
  return (
    <ThemeProvider>
      <div className="min-h-screen bg-default text-default">
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/create-markdown" element={
            <Suspense fallback={<div>Loading...</div>}>
              <PrivateRoute>
                <Layout header={<></>} footer={<Footer />}>
                  <CreateMarkdownFile />
                </Layout>
              </PrivateRoute>
            </Suspense>
          } />
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
              <Route path={`${item.baseUrl}/:categories`} element={
                <Suspense fallback={<div>Loading...</div>}>
                  <MarkdownPage
                    data={item.data}
                    title={item.label}
                    description={item.description}
                    baseUrl={item.baseUrl}
                  />
                </Suspense>
              } />

              {/* Route for topics within categories */}
              <Route path={`${item.baseUrl}/:categories/:topics`} element={
                <Suspense fallback={<div>Loading...</div>}>
                  <MarkdownPage
                    data={item.data}
                    title={item.label}
                    description={item.description}
                    baseUrl={item.baseUrl}
                  />
                </Suspense>
              } />

              {/* Route for sections within topics */}
              <Route path={`${item.baseUrl}/:categories/:topics/:sections`} element={
                <Suspense fallback={<div>Loading...</div>}>
                  <MarkdownPage
                    data={item.data}
                    title={item.label}
                    description={item.description}
                    baseUrl={item.baseUrl}
                  />
                </Suspense>
              } />

              {/* Route for chapters within sections */}
              <Route path={`${item.baseUrl}/:categories/:topics/:sections/:chapters`} element={
                <Suspense fallback={<div>Loading...</div>}>
                  <MarkdownPage
                    data={item.data}
                    title={item.label}
                    description={item.description}
                    baseUrl={item.baseUrl}
                  />
                </Suspense>
              } />

              {/* Route for slugs that can be at any level */}
              <Route path={`${item.baseUrl}/:categories/:topics/:sections/:chapters/:slug`} element={
                <Suspense fallback={<div>Loading...</div>}>
                  <MarkdownPage
                    data={item.data}
                    title={item.label}
                    description={item.description}
                    baseUrl={item.baseUrl}
                  />
                </Suspense>
              } />
              <Route path={`${item.baseUrl}/:categories/:topics/:sections/:slug`} element={
                <Suspense fallback={<div>Loading...</div>}>
                  <MarkdownPage
                    data={item.data}
                    title={item.label}
                    description={item.description}
                    baseUrl={item.baseUrl}
                  />
                </Suspense>
              } />
              <Route path={`${item.baseUrl}/:categories/:topics/:slug`} element={
                <Suspense fallback={<div>Loading...</div>}>
                  <MarkdownPage
                    data={item.data}
                    title={item.label}
                    description={item.description}
                    baseUrl={item.baseUrl}
                  />
                </Suspense>
              } />
              <Route path={`${item.baseUrl}/:categories/:slug`} element={
                <Suspense fallback={<div>Loading...</div>}>
                  <MarkdownPage
                    data={item.data}
                    title={item.label}
                    description={item.description}
                    baseUrl={item.baseUrl}
                  />
                </Suspense>
              } />
              <Route path={`${item.baseUrl}/:slug`} element={
                <Suspense fallback={<div>Loading...</div>}>
                  <MarkdownPage
                    data={item.data}
                    title={item.label}
                    description={item.description}
                    baseUrl={item.baseUrl}
                  />
                </Suspense>
              } />
              <Route path={`${item.baseUrl}`} element={
                <Suspense fallback={<div>Loading...</div>}>
                  <MarkdownPage
                    data={item.data}
                    title={item.label}
                    description={item.description}
                    baseUrl={item.baseUrl}
                  />
                </Suspense>
              } />
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

          <Route path="/[...notfound]" element={<NotFound />} />
          <Route path="/about-asafarim" element={<About />} />
          <Route path="/logout" element={<LogoutPage />} />
          {token &&
            <>
              <Route path="/about/akkodis-targeted-resume" element={<AkkodisTargetedResume />} />
            </>
          }
          <Route path="/contact-asafarim" element={<Contact />} />
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
                <Layout header={<></>} footer={<Footer />}>
                  <UserProfile />
                </Layout>
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

          <Route path="/users" element={<PrivateRoute ><UsersList /></PrivateRoute>} />
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
          <Route path="/tags/delete/:id" element={<DeleteForm entity="tags"  />} />
          <Route path="/categories/add" element={<AddCategoryForm />} />
          <Route path="/categories/edit/:id" element={<EditCategoryForm />} />
          <Route path="/categories/delete/:id" element={<DeleteForm entity="categories"  />} />
          <Route path="/topics/add" element={<AddTopicForm />} />
          <Route path="/topics/edit/:id" element={<EditTopicForm />} />
          <Route path="/topics/delete/:id" element={<DeleteForm entity="topics"  />} />
          <Route path="/posts" element={<PostsList />} />
          <Route path="/posts/create" element={<CreatePost />} />
          <Route path="/posts/add" element={<AddPostForm />} />
          <Route path="/posts/edit/:id" element={<EditPostForm />} />
          <Route path="/posts/delete/:id" element={<DeleteForm entity="posts"  />} />
          <Route path="/sitemap-items/add" element={<AddSitemapItemForm />} />
          <Route path="/sitemap-items/edit/:id" element={<EditSitemapItemForm />} />
          <Route path="/sitemap-items/delete/:id" element={<DeleteForm entity="sitemapitems"  />} />
          <Route path="/health" element={<HealthCheck />} />
          <Route path="/access-denied" element={<AccessDenied />} />
          <Route path="*" element={<NotFound />} />
        </Routes>
      </div>
    </ThemeProvider>
  );
};

export default App;
