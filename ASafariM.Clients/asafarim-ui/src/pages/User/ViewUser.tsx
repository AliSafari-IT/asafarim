 import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { getUserById, getRolesByUserId, getRoles } from '../../api/userService';
import { IUser } from '../../interfaces/IUser';
import Wrapper from '../../layout/Wrapper/Wrapper';
import Footer from '../../layout/Footer/Footer';
import Header from '@/layout/Header/Header';
import { logger } from '@/utils/logger';
import { IApiResponse, IRole, IUserRole } from '@/interfaces';

const ViewUser: React.FC = () => {
  const { id } = useParams<{ id: string }>();
  const navigate = useNavigate();
  const [user, setUser] = useState<IUser | null>(null);
  const [error, setError] = useState<string | null>(null);
  const [userRoles, setUserRoles] = useState<string[]>([]);
  const [roleNames, setRoleNames] = useState<{ [key: string]: string }>({});

  useEffect(() => {
    const fetchData = async () => {
      if (!id) return;
      try {
        // Fetch user first since we need it to check if it exists
        const userResponse = await getUserById(id);
        console.log('User response:', userResponse);
        // For single user, the response is the direct object
        const userData = userResponse;
        console.log('Processed user data:', userData);
        
        if (!userData || !userData.id) {
          throw new Error('User not found');
        }

        if (userData.dateOfBirth) {
          userData.dateOfBirth = new Date(userData.dateOfBirth)
            .toISOString()
            .split('T')[0];
        }
        setUser(userData);

        // Fetch all roles to get the mapping
        const rolesResponse = await getRoles();
        console.log('Roles response:', rolesResponse);
        const apiResponse = rolesResponse as IApiResponse<IRole>;
        const rolesArray = apiResponse.$values || apiResponse.value || rolesResponse;
        if (!Array.isArray(rolesArray)) {
          console.error('Invalid roles data format:', rolesResponse);
          throw new Error('Invalid roles data format');
        }
        
        const rolesMap = rolesArray.reduce((acc: { [key: string]: string }, role: IRole) => {
          acc[role.id] = role.name;
          return acc;
        }, {});
        setRoleNames(rolesMap);

        // Fetch user roles
        const rolesResponse2 = await getRolesByUserId(id);
        console.log('User roles response:', rolesResponse2);
        const apiResponse2 = rolesResponse2 as IApiResponse<IUserRole>;
        const userRolesArray = apiResponse2.$values || apiResponse2.value || rolesResponse2;
        if (!Array.isArray(userRolesArray)) {
          console.error('Invalid user roles data format:', rolesResponse2);
          throw new Error('Invalid user roles data format');
        }
        
        setUserRoles(userRolesArray.map((role) => role.roleId) || []);
      } catch (err) {
        console.error('Error details:', err);
        logger.error(`Failed to fetch user or roles: ${err}`);
        setError('Failed to load user data.');
      }
    };

    fetchData();
  }, [id]);

  if (!user) return <p>Loading...</p>;

  // Convert role IDs to names
  const getRoleNameById = (roleId: string) => roleNames[roleId] || roleId;

  return (
    <Wrapper
      header={<Header children={<h1 className="text-2xl font-semibold text-[var(--text-info)]">View User</h1>} />}
      footer={<Footer />}
    >
      <div className="w-full max-w-6xl mx-auto px-4 sm:px-6 lg:px-8 py-4 sm:py-6">
        <div className="bg-white dark:bg-gray-800 shadow-lg rounded-lg p-4 sm:p-6 lg:p-8 transition-colors duration-200">
          {error && (
            <p className="text-red-500 dark:text-red-400 text-sm mb-4">
              {error}
            </p>
          )}
          <h1 className="text-xl sm:text-2xl font-semibold text-center text-[var(--text-warning)] dark:text-[var(--warning)] mb-4 sm:mb-6 transition-colors duration-200">
            User Details
          </h1>
          
          <div className="grid grid-cols-1 md:grid-cols-2 gap-4 sm:gap-6">
            {/* Roles */}
            <div>
              <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                Roles
              </label>
              <div className="w-full px-3 sm:px-4 py-2 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg">
                {userRoles.length > 0 
                  ? userRoles.map(roleId => getRoleNameById(roleId)).join(', ')
                  : 'No roles assigned'}
              </div>
            </div>

            {/* First Name */}
            <div>
              <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                First Name
              </label>
              <div className="w-full px-3 sm:px-4 py-2 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg">
                {user.firstName || 'N/A'}
              </div>
            </div>

            {/* Last Name */}
            <div>
              <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                Last Name
              </label>
              <div className="w-full px-3 sm:px-4 py-2 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg">
                {user.lastName || 'N/A'}
              </div>
            </div>

            {/* User Name */}
            <div>
              <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                User Name
              </label>
              <div className="w-full px-3 sm:px-4 py-2 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg">
                {user.userName || 'N/A'}
              </div>
            </div>

            {/* Email */}
            <div>
              <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                Email
              </label>
              <div className="w-full px-3 sm:px-4 py-2 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg">
                {user.email || 'N/A'}
              </div>
            </div>

            {/* Date of Birth */}
            <div>
              <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                Date of Birth
              </label>
              <div className="w-full px-3 sm:px-4 py-2 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg">
                {user.dateOfBirth || 'N/A'}
              </div>
            </div>

            {/* Profile Picture */}
            <div>
              <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                Profile Picture
              </label>
              <div className="w-full px-3 sm:px-4 py-2 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg">
                {user.profilePicture ? (
                  <img 
                    src={user.profilePicture} 
                    alt="Profile" 
                    className="w-20 h-20 object-cover rounded-full"
                  />
                ) : 'No profile picture'}
              </div>
            </div>

            {/* Remark */}
            <div>
              <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                Remark
              </label>
              <div className="w-full px-3 sm:px-4 py-2 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg">
                {user.remark || 'N/A'}
              </div>
            </div>

            {/* Biography */}
            <div className="col-span-2">
              <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                Biography
              </label>
              <div className="w-full px-3 sm:px-4 py-2 bg-gray-50 dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg min-h-[100px]">
                {user.biography || 'No biography available'}
              </div>
            </div>
          </div>

          {/* Status Information */}
          <div className="mt-6 space-y-4">
            <div className="flex items-center space-x-2">
              <span className="text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base">Admin Status:</span>
              <span className={`px-2 py-1 rounded ${user.isAdmin ? 'bg-green-100 text-green-800' : 'bg-gray-100 text-gray-800'}`}>
                {user.isAdmin ? 'Admin' : 'Not Admin'}
              </span>
            </div>

            <div className="flex items-center space-x-2">
              <span className="text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base">Account Status:</span>
              <span className={`px-2 py-1 rounded ${user.isActive ? 'bg-green-100 text-green-800' : 'bg-red-100 text-red-800'}`}>
                {user.isActive ? 'Active' : 'Inactive'}
              </span>
            </div>
          </div>

          <div className="flex justify-end space-x-4 mt-6">
            <button
              type="button"
              onClick={() => navigate('/users')}
              className="px-4 py-2 bg-gradient-to-r from-[var(--success-dark)] to-[var(--success)] text-white rounded-lg hover:bg-gradient-to-r hover:from-[var(--success)] hover:to-[var(--success-light)] focus:outline-none focus:ring-2 focus:ring-[var(--success-light)] transition-all duration-300 shadow-md hover:shadow-lg"
            >
              Back to Users
            </button>
            <button
              type="button"
              onClick={() => navigate(`/users/edit/${id}`)}
              className="px-4 py-2 bg-gradient-to-r from-[var(--teams-purple-dark)] to-[var(--teams-purple)] text-white rounded-lg hover:bg-gradient-to-r hover:from-[var(--teams-purple)] hover:to-[var(--teams-purple-light)] focus:outline-none focus:ring-2 focus:ring-[var(--teams-purple-light)] transition-all duration-300 shadow-md hover:shadow-purple-lg"
            >
              Edit User
            </button>
          </div>
        </div>
      </div>
    </Wrapper>
  );
};

export default ViewUser;