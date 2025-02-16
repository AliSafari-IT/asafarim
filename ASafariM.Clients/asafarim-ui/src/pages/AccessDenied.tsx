import { useNavigate } from "react-router-dom";

const AccessDenied: React.FC = () => {
    const navigate = useNavigate();

    return (
      <div className="flex flex-col items-center justify-center h-screen bg-red-100">
        <h1 className="text-4xl font-bold text-red-600">Access Denied</h1>
        <p className="text-lg text-red-500 mt-4">
          You do not have permission to view the requested page.
        </p>
        <button
          onClick={() => navigate('/')}
          className="mt-6 px-6 py-2 bg-red-600 text-white rounded-lg"
        >
          Go to Home
        </button>
      </div>
    );
  };
  
  export default AccessDenied;
  