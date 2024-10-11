import DefaultFooter from '../DefaultFooter/DefaultFooter';
import DefaultHeader from '../DefaultHeader/DefaultHeader';
import Navbar from '../Navbar/Navbar';

// Define types for props
interface LayoutProps {
  header?: React.ReactNode;  // Optional header
  footer?: React.ReactNode;  // Optional footer
  children: React.ReactNode; // Required children
}

// Layout component with default or custom header and footer
const Wrapper: React.FC<LayoutProps> = ({ header, footer, children }) => {
  return (
    <div className="flex flex-col items-center justify-center min-h-screen w-full m-0 bg-gray-800 text-black bg-gradient-to-r from-blue-500 to-indigo-600">
      {/* Render header if provided, otherwise default */}
      <Navbar/>
      {header ?? <DefaultHeader />}

      {/* Main content */}
      <main className="flex-grow p-1">{children}</main>

      {/* Render footer if provided, otherwise default */}
      {footer ?? <DefaultFooter />}
    </div>
  );
};

export default Wrapper;
