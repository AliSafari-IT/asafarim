 import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { getUserById, getRolesByUserId, getRoles } from '../../api/userService';
import { IUser } from '../../interfaces/IUser';
import Wrapper from '../../layout/Wrapper';
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
  const [isLoading, setIsLoading] = useState<boolean>(true);

  useEffect(() => {
    const fetchData = async () => {
      if (!id) return;
      try {
        setIsLoading(true);
        // Fetch user first since we need it to check if it exists
        const userResponse = await getUserById(id);
        logger.debug('User response:', userResponse);
        // For single user, the response is the direct object
        const userData = userResponse;
        logger.debug('Processed user data:', userData);
        
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
        logger.debug('Roles response:', rolesResponse);
        const apiResponse = rolesResponse as IApiResponse<IRole>;
        const rolesArray = apiResponse.$values || apiResponse.value || rolesResponse;
        if (!Array.isArray(rolesArray)) {
          logger.error('Invalid roles data format:', rolesResponse);
          throw new Error('Invalid roles data format');
        }
        
        const rolesMap = rolesArray.reduce((acc: { [key: string]: string }, role: IRole) => {
          acc[role.id] = role.name;
          return acc;
        }, {});
        setRoleNames(rolesMap);

        // Fetch user roles
        const rolesResponse2 = await getRolesByUserId(id);
        logger.debug('User roles response:', rolesResponse2);
        const apiResponse2 = rolesResponse2 as IApiResponse<IUserRole>;
        const userRolesArray = apiResponse2.$values || apiResponse2.value || rolesResponse2;
        if (!Array.isArray(userRolesArray)) {
          logger.error('Invalid user roles data format:', rolesResponse2);
          throw new Error('Invalid user roles data format');
        }
        
        setUserRoles(userRolesArray.map((role) => role.roleId) || []);
        setIsLoading(false);
      } catch (err) {
        logger.error('Error details:', err);
        logger.error(`Failed to fetch user or roles: ${err}`);
        setError('Failed to load user data.');
        setIsLoading(false);
      }
    };

    fetchData();
  }, [id]);

  // Generate user avatar initials
  const getUserInitials = () => {
    if (!user) return '';
    const firstInitial = user.firstName ? user.firstName.charAt(0).toUpperCase() : '';
    const lastInitial = user.lastName ? user.lastName.charAt(0).toUpperCase() : '';
    return `${firstInitial}${lastInitial}`;
  };

  // Convert role IDs to names
  const getRoleNameById = (roleId: string) => roleNames[roleId] || roleId;

  if (isLoading) {
    return (
      <Wrapper header={<Header />} footer={<Footer />}>
        <div className="flex justify-center items-center h-[70vh]">
          <div className="animate-spin rounded-full h-16 w-16 border-t-2 border-b-2 border-[var(--info)]"></div>
        </div>
      </Wrapper>
    );
  }

  if (!user) {
    return (
      <Wrapper header={<Header />} footer={<Footer />}>
        <div className="flex flex-col justify-center items-center h-[70vh]">
          <div className="text-2xl text-red-500 mb-4">User not found</div>
          <button
            onClick={() => navigate('/users')}
            className="px-4 py-2 bg-[var(--info)] text-white rounded-lg hover:bg-[var(--info-dark)] transition-colors"
          >
            Back to Users
          </button>
        </div>
      </Wrapper>
    );
  }

  return (
    <Wrapper header={<Header />} footer={<Footer />}>
      <div className="container mx-auto px-4 py-8 max-w-5xl">
        <div className="flex items-center justify-between mb-6">
          <div>
            <button 
              onClick={() => navigate('/users')}
              className="flex items-center text-[var(--info)] hover:text-[var(--info-dark)] transition-colors duration-200"
            >
              <svg xmlns="http://www.w3.org/2000/svg" className="h-5 w-5 mr-1" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M10 19l-7-7m0 0l7-7m-7 7h18" />
              </svg>
              Back to Users
            </button>
            <h1 className="text-2xl font-bold text-gray-800 dark:text-gray-100 mt-2">
              User Profile
            </h1>
          </div>
          <button
            onClick={() => navigate(`/users/edit/${id}`)}
            className={`px-4 py-2 rounded-lg shadow-md transition-all duration-200 ${
              user.isDeleted 
                ? 'bg-gray-300 text-gray-600 cursor-not-allowed' 
                : 'bg-[var(--info)] text-white hover:bg-[var(--info-dark)] hover:shadow-lg'
            }`}
            disabled={user.isDeleted}
          >
            {user.isDeleted ? 'Cannot Edit Deleted User' : 'Edit User'}
          </button>
        </div>

        {error && (
          <div className="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded relative mb-4" role="alert">
            <span className="block sm:inline">{error}</span>
          </div>
        )}

        {user.isDeleted && (
          <div className="bg-yellow-100 border border-yellow-400 text-yellow-700 px-4 py-3 rounded relative mb-4" role="alert">
            <span className="font-bold">Note:</span>
            <span className="block sm:inline"> This account has been deleted. The user must request reactivation before any updates can be made.</span>
          </div>
        )}

        <div className="bg-white dark:bg-gray-800 shadow-lg rounded-lg overflow-hidden">
          {/* User Header with Avatar */}
          <div className="bg-gradient-to-r from-[var(--info-light)] to-[var(--info)] p-6 flex items-center">
            {user.profilePicture ? (
              <img 
                src={user.profilePicture} 
                alt={`${user.firstName} ${user.lastName}`}
                className="w-20 h-20 rounded-full object-cover border-4 border-white shadow-md" 
              />
            ) : (
              <div className="w-20 h-20 rounded-full bg-white text-[var(--info)] flex items-center justify-center text-2xl font-bold border-4 border-white shadow-md">
                {getUserInitials()}
              </div>
            )}
            <div className="ml-6 text-white">
              <h2 className="text-2xl font-bold">{user.firstName} {user.lastName}</h2>
              <p className="opacity-90">{user.userName || user.email}</p>
              <div className="flex mt-2 space-x-2">
                <span className={`px-2 py-1 text-xs rounded-full font-medium ${user.isAdmin ? 'bg-purple-200 text-purple-800' : 'bg-gray-200 text-gray-800'}`}>
                  {user.isAdmin ? 'Administrator' : 'Standard User'}
                </span>
                <span className={`px-2 py-1 text-xs rounded-full font-medium ${
                  user.isDeleted 
                    ? 'bg-red-200 text-red-800' 
                    : (user.isActive ? 'bg-green-200 text-green-800' : 'bg-yellow-200 text-yellow-800')
                }`}>
                  {user.isDeleted ? 'Deleted' : (user.isActive ? 'Active' : 'Inactive')}
                </span>
              </div>
            </div>
          </div>

          {/* User Details */}
          <div className="p-6">
            <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
              {/* Roles */}
              <div className="space-y-2">
                <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Roles</h3>
                <div className="flex flex-wrap gap-2">
                  {userRoles.length > 0 ? (
                    userRoles.map((roleId, index) => (
                      <span 
                        key={index}
                        className="px-3 py-1 bg-blue-100 text-blue-800 dark:bg-blue-900 dark:text-blue-200 rounded-full text-sm"
                      >
                        {getRoleNameById(roleId)}
                      </span>
                    ))
                  ) : (
                    <span className="text-gray-500 dark:text-gray-400">No roles assigned</span>
                  )}
                </div>
              </div>

              {/* Email */}
              <div className="space-y-2">
                <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Email</h3>
                <p className="text-gray-700 dark:text-gray-300">{user.email || 'N/A'}</p>
              </div>

              {/* Username */}
              <div className="space-y-2">
                <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Username</h3>
                <p className="text-gray-700 dark:text-gray-300">{user.userName || 'N/A'}</p>
              </div>

              {/* Date of Birth */}
              <div className="space-y-2">
                <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Date of Birth</h3>
                <p className="text-gray-700 dark:text-gray-300">{user.dateOfBirth || 'N/A'}</p>
              </div>

              {/* Remark */}
              <div className="space-y-2">
                <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Remark</h3>
                <p className="text-gray-700 dark:text-gray-300">{user.remark || 'N/A'}</p>
              </div>

              {/* Last Login */}
              <div className="space-y-2">
                <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Last Login</h3>
                <p className="text-gray-700 dark:text-gray-300">
                  {user.lastLogin ? new Date(user.lastLogin).toLocaleString() : 'Never'}
                </p>
              </div>

              {/* Biography */}
              <div className="md:col-span-2 space-y-2">
                <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Biography</h3>
                <div className="p-4 bg-gray-50 dark:bg-gray-700/50 rounded-lg border border-gray-200 dark:border-gray-700 min-h-[100px]">
                  <p className="text-gray-700 dark:text-gray-300 whitespace-pre-line">
                    {user.biography || 'No biography available'}
                  </p>
                </div>
              </div>
            </div>

            {/* Account Details */}
            <div className="mt-8 border-t border-gray-200 dark:border-gray-700 pt-6">
              <h3 className="text-lg font-medium text-gray-900 dark:text-gray-100 mb-4">Account Information</h3>
              
              <div className="grid grid-cols-1 md:grid-cols-3 gap-4">
                <div className="p-4 bg-gray-50 dark:bg-gray-700/50 rounded-lg border border-gray-200 dark:border-gray-700">
                  <div className="flex items-center">
                    <div className={`w-3 h-3 rounded-full ${user.isActive ? 'bg-green-500' : 'bg-red-500'} mr-2`}></div>
                    <span className="text-sm font-medium">Account Status</span>
                  </div>
                  <p className="mt-1 text-gray-500 dark:text-gray-400 text-sm">
                    {user.isActive ? 'Active' : 'Inactive'}
                  </p>
                </div>

                <div className="p-4 bg-gray-50 dark:bg-gray-700/50 rounded-lg border border-gray-200 dark:border-gray-700">
                  <div className="flex items-center">
                    <div className={`w-3 h-3 rounded-full ${user.isAdmin ? 'bg-purple-500' : 'bg-gray-500'} mr-2`}></div>
                    <span className="text-sm font-medium">Admin Status</span>
                  </div>
                  <p className="mt-1 text-gray-500 dark:text-gray-400 text-sm">
                    {user.isAdmin ? 'Administrator' : 'Standard User'}
                  </p>
                </div>

                <div className="p-4 bg-gray-50 dark:bg-gray-700/50 rounded-lg border border-gray-200 dark:border-gray-700">
                  <div className="flex items-center">
                    <div className={`w-3 h-3 rounded-full ${user.isDeleted ? 'bg-red-500' : 'bg-green-500'} mr-2`}></div>
                    <span className="text-sm font-medium">Deletion Status</span>
                  </div>
                  <p className="mt-1 text-gray-500 dark:text-gray-400 text-sm">
                    {user.isDeleted ? `Deleted on ${user.deletedAt ? new Date(user.deletedAt).toLocaleDateString() : 'Unknown date'}` : 'Not Deleted'}
                  </p>
                </div>
              </div>
            </div>

            {/* Dates Information */}
            <div className="mt-8 border-t border-gray-200 dark:border-gray-700 pt-6">
              <div className="grid grid-cols-1 md:grid-cols-3 gap-4 text-sm">
                <div>
                  <span className="text-gray-500 dark:text-gray-400">Created:</span>
                  <span className="ml-2 text-gray-700 dark:text-gray-300">
                    {user.createdAt ? new Date(user.createdAt).toLocaleString() : 'Unknown'}
                  </span>
                </div>
                <div>
                  <span className="text-gray-500 dark:text-gray-400">Last Updated:</span>
                  <span className="ml-2 text-gray-700 dark:text-gray-300">
                    {user.updatedAt ? new Date(user.updatedAt).toLocaleString() : 'Never'}
                  </span>
                </div>
                <div>
                  <span className="text-gray-500 dark:text-gray-400">Last Password Change:</span>
                  <span className="ml-2 text-gray-700 dark:text-gray-300">
                    {user.lastPasswordChangeDate ? new Date(user.lastPasswordChangeDate).toLocaleString() : 'Never'}
                  </span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </Wrapper>
  );
};

export default ViewUser;