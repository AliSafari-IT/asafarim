import DefaultFooter from '../DefaultFooter/DefaultFooter';
import DefaultHeader from '../DefaultHeader/DefaultHeader';
import Navbar from '../Navbar/Navbar';

// Define types for props
interface LayoutProps {
  header?: React.ReactNode;
  footer?: React.ReactNode;
  children?: React.ReactNode; // Make children optional
}


// Layout component with default or custom header and footer
const Wrapper: React.FC<LayoutProps> = ({ header, footer, children }) => {
  return (
    <div className="flex flex-col items-center justify-center min-h-screen w-full m-0 bg-gray-800 text-black bg-gradient-to-r from-blue-500 to-indigo-600">
      <Navbar />
      {header ?? <DefaultHeader />}
      <main className="flex-grow p-1">{children}</main>
      {footer ?? <DefaultFooter />}
    </div>
  );
};

export default Wrapper;  // Ensure this is present

