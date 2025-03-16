// E:\asm-fs\apps\frontends\asafarim-client\src\pages\User\UsersList.tsx
import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import { IUser } from '../../interfaces/IUser';
import { deleteUserByAdmin, getUsers, getRolesByUserId, getRoles } from '../../api/userService';
import Wrapper from '../../layout/Wrapper/Wrapper';
import Footer from '../../layout/Footer/Footer';
import Header from '@/layout/Header/Header';
import { EditSvgIcon } from '@/assets/SvgIcons/EditSvgIcon';
import { DeleteSvgIcon } from '@/assets/SvgIcons/DeleteSvgIcon';
import { ViewSvgIcon } from '@/assets/SvgIcons/ViewSvgIcon';
import useAuth from '@/hooks/useAuth';
import axios from 'axios'; // Import axios
import Notification from '@/components/Notification/Notification';
import { IApiResponse, IRole, IUserRole } from '@/interfaces';
import { logger } from "@/utils/logger";

const UsersList: React.FC = () => {
  const [users, setUsers] = useState<IUser[]>([]);
  const [error, setError] = useState<string | null>(null); // Error state
  const [userRoles, setUserRoles] = useState<Record<string, string[]>>({});
  const [roleNamesMap, setRoleNamesMap] = useState<Record<string, string>>({});
  const { authenticatedUser } = useAuth();
  const [deleteDialogOpen, setDeleteDialogOpen] = useState(false);
  const [selectedUserId, setSelectedUserId] = useState<string | null>(null);
  const [isLoading, setIsLoading] = useState(true);
  const [searchTerm, setSearchTerm] = useState('');

  // Fetch users only once on mount
  useEffect(() => {
    const fetchUsers = async () => {
      setIsLoading(true);
      logger.debug('Fetching users!');
      try {
        logger.debug('Starting to fetch users...');
        const response = await getUsers(true); // Include soft-deleted users
        logger.debug('Successfully fetched users:', response);
        
        // Handle the new API response format
        const apiResponse = response as IApiResponse<IUser>;
        const usersArray = apiResponse.$values || apiResponse.value || response;
        if (Array.isArray(usersArray)) {
          setUsers(usersArray);
        } else {
          logger.error('Invalid users data format:', response);
          setError('Invalid data format received from server');
        }
      } catch (err) {
        logger.error('Error in UsersList component:', err);
        if (axios.isAxiosError(err)) {
          setError(`Failed to load users: ${err.response?.data || err.message}`);
        } else {
          setError('An unexpected error occurred while loading users.');
        }
      } finally {
        setIsLoading(false);
      }
    };
    fetchUsers();
  }, []);

  useEffect(() => {
    logger.debug("UsersList => users", users);
  }, [users]);

  const fetchUserRoles = async (userId: string) => {
    try {
      const response = await getRolesByUserId(userId);
      // Handle the new API response format
      const apiResponse = response as IApiResponse<IUserRole>;
      const rolesArray = apiResponse.$values || apiResponse.value || response;
      if (Array.isArray(rolesArray)) {
        const roleNames = rolesArray.map(role => role.roleId);
        setUserRoles(prev => ({ ...prev, [userId]: roleNames }));
      } else {
        logger.error('Invalid user roles data format:', response);
      }
    } catch (err) {
      logger.error('Error fetching roles for user', userId, err);
    }
  };

  useEffect(() => {
    users.forEach(user => {
      fetchUserRoles(user.id);
    });
  }, [users]);

  useEffect(() => {
    const fetchRoleNames = async () => {
      try {
        const response = await getRoles();
        // Handle the new API response format
        const apiResponse = response as IApiResponse<IRole>;
        const rolesArray = apiResponse.$values || apiResponse.value || response;
        if (Array.isArray(rolesArray)) {
          const newRoleNames = rolesArray.reduce((acc, role) => {
            acc[role.id] = role.name;
            return acc;
          }, {} as Record<string, string>);
          setRoleNamesMap(prev => ({ ...prev, ...newRoleNames }));
        } else {
          logger.error('Invalid roles data format:', response);
        }
      } catch (err) {
        logger.error('Error fetching role names:', err);
      }
    };

    fetchRoleNames();
  }, [userRoles]);

  const handleDeleteClick = (id: string) => {
    // Check if logged-in user is admin
    if (!authenticatedUser?.isAdmin) {
      setError('You do not have sufficient rights to delete users.');
      return;
    }
    setSelectedUserId(id);
    setDeleteDialogOpen(true);
  };

  const handleSoftDelete = async () => {
    if (!selectedUserId) return;

    try {
      await deleteUserByAdmin(selectedUserId, false);
      setUsers(prevUsers => prevUsers.map(user =>
        user.id === selectedUserId ? { ...user, isDeleted: true, deletedAt: new Date().toISOString() } : user
      ));
    } catch (err) {
      setError('Failed to soft delete the user.');
      logger.error(err);
    } finally {
      setDeleteDialogOpen(false);
      setSelectedUserId(null);
    }
  };

  const handlePermanentDelete = async () => {
    if (!selectedUserId) return;

    try {
      await deleteUserByAdmin(selectedUserId, true);
      setUsers(prevUsers => prevUsers.filter(user => user.id !== selectedUserId));
    } catch (err) {
      setError('Failed to delete the user.');
      logger.error(err);
    } finally {
      setDeleteDialogOpen(false);
      setSelectedUserId(null);
    }
  };

  const handleCancelDelete = () => {
    setDeleteDialogOpen(false);
    setSelectedUserId(null);
  };

  const filteredUsers = users.filter(user => {
    const searchLower = searchTerm.toLowerCase();
    return (
      user.firstName?.toLowerCase().includes(searchLower) ||
      user.lastName?.toLowerCase().includes(searchLower) ||
      user.userName?.toLowerCase().includes(searchLower) || 
      false
    );
  });

  return (
    <Wrapper
      header={<Header children={<h1 className="text-2xl font-semibold text-[var(--text-info)]">Users List</h1>} />}
      footer={<Footer />}
    >
      <div className="max-w-7xl mx-auto p-6">
        <div className="bg-white dark:bg-gray-800 rounded-xl shadow-lg overflow-hidden border border-gray-200 dark:border-gray-700">
          {/* Header Section */}
          <div className="bg-gradient-to-r from-blue-50 to-indigo-50 dark:from-gray-800 dark:to-gray-700 p-6 border-b border-gray-200 dark:border-gray-700">
            <div className="flex flex-col md:flex-row md:items-center justify-between gap-4">
              <div>
                <h1 className="text-2xl font-bold text-gray-800 dark:text-white">User Management</h1>
                <p className="text-gray-600 dark:text-gray-300 mt-1">Manage your system users and their roles</p>
              </div>
              
              <Link
                to="/users/create"
                className="flex items-center justify-center gap-2 bg-blue-600 hover:bg-blue-700 text-white px-4 py-2 rounded-lg transition-colors duration-200 shadow-md"
              >
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  className="h-5 w-5"
                  fill="none"
                  viewBox="0 0 24 24"
                  stroke="currentColor"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    strokeWidth={2}
                    d="M12 9v3m0 0v3m0-3h3m-3 0H9m12 0a9 9 0 11-18 0 9 9 0 0118 0z"
                  />
                </svg>
                <span>Create User</span>
              </Link>
            </div>
          </div>

          {/* Search and Filters */}
          <div className="p-4 bg-gray-50 dark:bg-gray-800 border-b border-gray-200 dark:border-gray-700">
            <div className="relative">
              <div className="absolute inset-y-0 left-0 flex items-center pl-3 pointer-events-none">
                <svg className="w-4 h-4 text-gray-500 dark:text-gray-400" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 20 20">
                  <path stroke="currentColor" strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="m19 19-4-4m0-7A7 7 0 1 1 1 8a7 7 0 0 1 14 0Z"/>
                </svg>
              </div>
              <input 
                type="search" 
                className="block w-full p-2 pl-10 text-sm text-gray-900 border border-gray-300 rounded-lg bg-white focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" 
                placeholder="Search users..." 
                value={searchTerm}
                onChange={(e) => setSearchTerm(e.target.value)}
              />
            </div>
          </div>

          {error && (
            <div className="p-4">
              <Notification type="error" text={error} role="alert" onDismiss={() => setError(null)} />
            </div>
          )}

          {/* Loading State */}
          {isLoading ? (
            <div className="flex justify-center items-center p-12">
              <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-blue-500"></div>
            </div>
          ) : (
            <>
              {/* Table */}
              <div className="overflow-x-auto">
                <table className="min-w-full divide-y divide-gray-200 dark:divide-gray-700">
                  <thead className="bg-gray-50 dark:bg-gray-700">
                    <tr>
                      <th scope="col" className="px-4 py-3.5 text-left text-xs font-medium text-gray-500 dark:text-gray-300 uppercase tracking-wider">#</th>
                      <th scope="col" className="px-4 py-3.5 text-left text-xs font-medium text-gray-500 dark:text-gray-300 uppercase tracking-wider">Name</th>
                      <th scope="col" className="hidden sm:table-cell px-4 py-3.5 text-left text-xs font-medium text-gray-500 dark:text-gray-300 uppercase tracking-wider">Last Name</th>
                      <th scope="col" className="px-4 py-3.5 text-left text-xs font-medium text-gray-500 dark:text-gray-300 uppercase tracking-wider">Username</th>
                      <th scope="col" className="hidden md:table-cell px-4 py-3.5 text-left text-xs font-medium text-gray-500 dark:text-gray-300 uppercase tracking-wider">Roles</th>
                      <th scope="col" className="px-4 py-3.5 text-left text-xs font-medium text-gray-500 dark:text-gray-300 uppercase tracking-wider">Status</th>
                      <th scope="col" className="px-4 py-3.5 text-left text-xs font-medium text-gray-500 dark:text-gray-300 uppercase tracking-wider">Actions</th>
                    </tr>
                  </thead>
                  <tbody className="bg-white dark:bg-gray-800 divide-y divide-gray-200 dark:divide-gray-700">
                    {filteredUsers.length === 0 ? (
                      <tr>
                        <td colSpan={7} className="px-4 py-8 text-center text-gray-500 dark:text-gray-400">
                          {searchTerm ? 'No users match your search criteria' : 'No users found'}
                        </td>
                      </tr>
                    ) : (
                      filteredUsers.map((user, i) => {
                        const deletedStyle = user.isDeleted ? { opacity: 0.6 } : {};
                        return (
                          <tr 
                            key={user.id} 
                            className="hover:bg-gray-50 dark:hover:bg-gray-700 transition-colors"
                            style={deletedStyle}
                          >
                            <td className="px-4 py-4 whitespace-nowrap text-sm text-gray-500 dark:text-gray-400">{i + 1}</td>
                            <td className="px-4 py-4 whitespace-nowrap">
                              <div className="flex items-center">
                                <div className="flex-shrink-0 h-10 w-10 bg-gray-200 dark:bg-gray-600 rounded-full flex items-center justify-center">
                                  <span className="text-gray-600 dark:text-gray-300 font-medium">
                                    {user.firstName.charAt(0)}{user.lastName.charAt(0)}
                                  </span>
                                </div>
                                <div className="ml-4">
                                  <div className="text-sm font-medium text-gray-900 dark:text-white">
                                    {user.firstName}
                                  </div>
                                  <div className="text-sm text-gray-500 dark:text-gray-400 sm:hidden">
                                    {user.lastName}
                                  </div>
                                </div>
                              </div>
                            </td>
                            <td className="hidden sm:table-cell px-4 py-4 whitespace-nowrap text-sm text-gray-500 dark:text-gray-400">
                              {user.lastName}
                            </td>
                            <td className="px-4 py-4 whitespace-nowrap text-sm text-gray-500 dark:text-gray-400">
                              {user.userName}
                            </td>
                            <td className="hidden md:table-cell px-4 py-4 whitespace-nowrap">
                              <div className="flex flex-wrap gap-1">
                                {userRoles[user.id]?.map((roleId, index) => (
                                  <span
                                    key={`${index}_${user.id}-${roleId}`}
                                    className="inline-block bg-blue-100 dark:bg-blue-900 text-blue-800 dark:text-blue-200 text-xs px-2 py-0.5 rounded-full"
                                  >
                                    {roleNamesMap[roleId] || roleId}
                                  </span>
                                )) || (
                                  <span className="text-xs text-gray-500 dark:text-gray-400">No roles</span>
                                )}
                              </div>
                            </td>
                            <td className="px-4 py-4 whitespace-nowrap">
                              {user.isDeleted ? (
                                <span className="inline-flex items-center px-2.5 py-0.5 rounded-full text-xs font-medium bg-red-100 text-red-800 dark:bg-red-900 dark:text-red-200">
                                  Deleted
                                </span>
                              ) : (
                                <span className="inline-flex items-center px-2.5 py-0.5 rounded-full text-xs font-medium bg-green-100 text-green-800 dark:bg-green-900 dark:text-green-200">
                                  Active
                                </span>
                              )}
                            </td>
                            <td className="px-4 py-4 whitespace-nowrap text-sm font-medium">
                              <div className="flex items-center space-x-2">
                                <Link
                                  to={`/users/view/${user.id}`}
                                  className="p-1.5 bg-blue-50 hover:bg-blue-100 dark:bg-blue-900/30 dark:hover:bg-blue-900/50 text-blue-600 dark:text-blue-400 rounded-lg transition-colors"
                                  title="View User"
                                >
                                  {ViewSvgIcon}
                                </Link>
                                <Link
                                  to={`/users/edit/${user.id}`}
                                  className="p-1.5 bg-amber-50 hover:bg-amber-100 dark:bg-amber-900/30 dark:hover:bg-amber-900/50 text-amber-600 dark:text-amber-400 rounded-lg transition-colors"
                                  title="Edit User"
                                >
                                  {EditSvgIcon}
                                </Link>
                                <button
                                  onClick={() => handleDeleteClick(user.id)}
                                  className="p-1.5 bg-red-50 hover:bg-red-100 dark:bg-red-900/30 dark:hover:bg-red-900/50 text-red-600 dark:text-red-400 rounded-lg transition-colors"
                                  title="Delete User"
                                >
                                  {DeleteSvgIcon}
                                </button>
                              </div>
                            </td>
                          </tr>
                        );
                      })
                    )}
                  </tbody>
                </table>
              </div>
              
              {/* Pagination Placeholder - Can be implemented later */}
              <div className="bg-white dark:bg-gray-800 px-4 py-3 flex items-center justify-between border-t border-gray-200 dark:border-gray-700 sm:px-6">
                <div className="hidden sm:flex-1 sm:flex sm:items-center sm:justify-between">
                  <div>
                    <p className="text-sm text-gray-700 dark:text-gray-300">
                      Showing <span className="font-medium">{filteredUsers.length}</span> of{" "}
                      <span className="font-medium">{users.length}</span> users
                    </p>
                  </div>
                </div>
              </div>
            </>
          )}
        </div>
      </div>

      {/* Delete Dialog */}
      {deleteDialogOpen && (
        <div className="fixed inset-0 bg-black/70 backdrop-blur-sm flex items-center justify-center z-50">
          <div className="bg-white dark:bg-gray-800 p-8 rounded-xl shadow-xl max-w-md w-full mx-4 transform transition-all">
            <div className="text-center mb-6">
              <div className="w-16 h-16 mx-auto mb-4 rounded-full bg-red-100 dark:bg-red-900/50 flex items-center justify-center">
                <svg xmlns="http://www.w3.org/2000/svg" className="h-8 w-8 text-red-600 dark:text-red-400" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                  <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M19 7l-.867 12.142A2 2 0 0116.138 21H7.862a2 2 0 01-1.995-1.858L5 7m5 4v6m4-6v6m1-10V4a1 1 0 00-1-1h-4a1 1 0 00-1 1v3M4 7h16" />
                </svg>
              </div>
              <h2 className="text-2xl font-bold text-gray-900 dark:text-white">Delete User</h2>
              <p className="mt-2 text-gray-600 dark:text-gray-300">Please select a deletion method:</p>
            </div>

            <div className="space-y-4">
              <button
                className="w-full group p-4 rounded-xl border-2 border-gray-200 dark:border-gray-700 hover:border-amber-500 hover:bg-amber-50 dark:hover:border-amber-600 dark:hover:bg-amber-900/20 transition-all duration-200 focus:outline-none focus:ring-2 focus:ring-amber-500 focus:ring-opacity-50"
                onClick={handleSoftDelete}
              >
                <div className="flex items-center gap-3 mb-2">
                  <div className="w-10 h-10 rounded-full bg-amber-500 dark:bg-amber-600 flex items-center justify-center">
                    <svg xmlns="http://www.w3.org/2000/svg" className="h-5 w-5 text-white" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                      <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M5 8h14M5 8a2 2 0 110-4h14a2 2 0 110 4M5 8v10a2 2 0 002 2h10a2 2 0 002-2V8m-9 4h4" />
                    </svg>
                  </div>
                  <h3 className="font-semibold text-lg text-gray-900 dark:text-white">Soft Delete</h3>
                </div>
                <p className="text-sm text-gray-600 dark:text-gray-300 pl-[52px]">
                  Marks the user as deleted while preserving their data. Can be restored later if needed.
                </p>
              </button>

              <button
                className="w-full group p-4 rounded-xl border-2 border-gray-200 dark:border-gray-700 hover:border-red-500 hover:bg-red-50 dark:hover:border-red-600 dark:hover:bg-red-900/20 transition-all duration-200 focus:outline-none focus:ring-2 focus:ring-red-500 focus:ring-opacity-50"
                onClick={handlePermanentDelete}
              >
                <div className="flex items-center gap-3 mb-2">
                  <div className="w-10 h-10 rounded-full bg-red-500 dark:bg-red-600 flex items-center justify-center">
                    <svg xmlns="http://www.w3.org/2000/svg" className="h-5 w-5 text-white" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                      <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M19 7l-.867 12.142A2 2 0 0116.138 21H7.862a2 2 0 01-1.995-1.858L5 7m5 4v6m4-6v6m1-10V4a1 1 0 00-1-1h-4a1 1 0 00-1 1v3M4 7h16" />
                    </svg>
                  </div>
                  <h3 className="font-semibold text-lg text-gray-900 dark:text-white">Permanent Delete</h3>
                </div>
                <p className="text-sm text-gray-600 dark:text-gray-300 pl-[52px]">
                  Permanently removes all user data. This action cannot be undone.
                </p>
              </button>

              <div className="pt-4 flex justify-end">
                <button
                  onClick={handleCancelDelete}
                  className="px-6 py-2 border-2 border-gray-200 dark:border-gray-700 rounded-lg text-gray-700 dark:text-gray-300 hover:bg-gray-100 dark:hover:bg-gray-700 transition-all duration-200 focus:outline-none focus:ring-2 focus:ring-gray-300 dark:focus:ring-gray-600 focus:ring-opacity-50"
                >
                  Cancel
                </button>
              </div>
            </div>
          </div>
        </div>
      )}
    </Wrapper>
  );
};

export default UsersList;
