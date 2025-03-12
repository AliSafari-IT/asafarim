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

const UsersList: React.FC = () => {
  const [users, setUsers] = useState<IUser[]>([]);
  const [error, setError] = useState<string | null>(null); // Error state
  const [userRoles, setUserRoles] = useState<Record<string, string[]>>({});
  const [roleNamesMap, setRoleNamesMap] = useState<Record<string, string>>({});
  const { authenticatedUser } = useAuth();
  const [deleteDialogOpen, setDeleteDialogOpen] = useState(false);
  const [selectedUserId, setSelectedUserId] = useState<string | null>(null);

  // Fetch users only once on mount
  useEffect(() => {
    const fetchUsers = async () => {
      console.log('Fetching users!');
      try {
        console.log('Starting to fetch users...');
        const response = await getUsers(true); // Include soft-deleted users
        console.log('Successfully fetched users:', response);
        
        // Handle the new API response format
        const apiResponse = response as IApiResponse<IUser>;
        const usersArray = apiResponse.$values || apiResponse.value || response;
        if (Array.isArray(usersArray)) {
          setUsers(usersArray);
        } else {
          console.error('Invalid users data format:', response);
          setError('Invalid data format received from server');
        }
      } catch (err) {
        console.error('Error in UsersList component:', err);
        if (axios.isAxiosError(err)) {
          setError(`Failed to load users: ${err.response?.data || err.message}`);
        } else {
          setError('An unexpected error occurred while loading users.');
        }
      }
    };
    fetchUsers();
  }, []);

  useEffect(() => {
    console.log("UsersList => users", users);
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
        console.error('Invalid user roles data format:', response);
      }
    } catch (err) {
      console.error('Error fetching roles for user', userId, err);
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
          console.error('Invalid roles data format:', response);
        }
      } catch (err) {
        console.error('Error fetching role names:', err);
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
      console.error(err);
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
      console.error(err);
    } finally {
      setDeleteDialogOpen(false);
      setSelectedUserId(null);
    }
  };

  const handleCancelDelete = () => {
    setDeleteDialogOpen(false);
    setSelectedUserId(null);
  };

  return (
    <Wrapper
      header={<Header children={<h1 className="text-2xl font-semibold text-[var(--text-info)]">Users List</h1>} />}
      footer={<Footer />}
    >
      <div className="max-w-6xl mx-auto p-6 rounded-lg shadow-lg">
        <h1 className="text-2xl font-semibold text-center text-[var(--text-warning)] mb-6">User Management</h1>
        <Link
          to="/users/create"
          className="btn-info py-2 px-4 rounded-lg hover:bg-blue-700 mb-4 inline-block"
        >
          {/* Add Icon for "Create User" */}
          <svg
            xmlns="http://www.w3.org/2000/svg"
            className="h-6 w-6 inline-block"
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
          <span className="ml-2">Create User</span>
        </Link>

        {error && (
          <Notification type="error" text={error} role="alert" onDismiss={() => setError(null)} />
        )}
        <div className="overflow-x-auto rounded-lg border border-[var(--border-default)]">
          <table className="min-w-full table-auto">
            <thead className="bg-[var(--background-subtle)]">
              <tr>
                <th className="px-3 sm:px-4 py-3 text-left text-xs sm:text-sm text-info whitespace-nowrap">#</th>
                <th className="px-3 sm:px-4 py-3 text-left text-xs sm:text-sm text-info whitespace-nowrap">Name</th>
                <th className="hidden sm:table-cell px-3 sm:px-4 py-3 text-left text-xs sm:text-sm text-info whitespace-nowrap">Last Name</th>
                <th className="px-3 sm:px-4 py-3 text-left text-xs sm:text-sm text-info whitespace-nowrap">UserName</th>
                <th className="hidden md:table-cell px-3 sm:px-4 py-3 text-left text-xs sm:text-sm text-info whitespace-nowrap">Roles</th>
                <th className="px-3 sm:px-4 py-3 text-left text-xs sm:text-sm text-info whitespace-nowrap">Actions</th>
              </tr>
            </thead>
            <tbody className="divide-y divide-[var(--border-default)]">
              {users?.map((user, i) => {
                const deletedStyle = user.isDeleted ? { color: 'var(--text-danger)', textDecoration: 'line-through' } : {};
                return (
                  <tr key={user.id} className="hover:bg-[var(--background-subtle)] transition-colors">
                    <td className="px-3 sm:px-4 py-2 text-xs sm:text-sm whitespace-nowrap" style={deletedStyle}>{i + 1}</td>
                    <td className="px-3 sm:px-4 py-2 text-xs sm:text-sm whitespace-nowrap" style={deletedStyle}>
                      <span className="sm:hidden">{user.firstName}</span>
                      <span className="hidden sm:inline">{user.firstName}</span>
                    </td>
                    <td className="hidden sm:table-cell px-3 sm:px-4 py-2 text-xs sm:text-sm whitespace-nowrap" style={deletedStyle}>{user.lastName}</td>
                    <td className="px-3 sm:px-4 py-2 text-xs sm:text-sm whitespace-nowrap" style={deletedStyle}>{user.userName}</td>
                    <td className="hidden md:table-cell px-3 sm:px-4 py-2 text-xs sm:text-sm">
                      <div className="flex flex-wrap gap-1">
                        {userRoles[user.id]?.map((roleId, index) => (
                          <span
                            key={`${index}_${user.id}-${roleId}`}
                            className="inline-block bg-[var(--background-info-subtle)] text-[var(--text-info)] text-xs px-2 py-0.5 rounded-full"
                          >
                            {roleNamesMap[roleId] || roleId}
                          </span>
                        )) || 'No roles'}
                      </div>
                    </td>
                    <td className="px-3 sm:px-4 py-2 text-xs sm:text-sm whitespace-nowrap">
                      <div className="flex items-center gap-2">
                        <Link
                          to={`/users/view/${user.id}`}
                          className="p-1 hover:bg-[var(--background-info-subtle)] rounded-full transition-colors"
                          title='View User'
                        >
                          {ViewSvgIcon}
                        </Link>
                        <Link
                          to={`/users/edit/${user.id}`}
                          className="p-1 hover:bg-[var(--background-warning-subtle)] rounded-full transition-colors"
                          title='Edit User'
                        >
                          {EditSvgIcon}
                        </Link>
                        <button
                          onClick={() => handleDeleteClick(user.id)}
                          className="p-1 hover:bg-[var(--background-danger-subtle)] rounded-full transition-colors"
                          title='Delete User'
                        >
                          {DeleteSvgIcon}
                        </button>
                      </div>
                    </td>
                  </tr>
                )
              })}
            </tbody>
          </table>
        </div>
        {deleteDialogOpen && (
          <div className="fixed inset-0 bg-black/70 backdrop-blur-sm flex items-center justify-center z-50">
            <div className="bg-[var(--bg-primary)] border border-[var(--border-secondary)] p-8 rounded-xl shadow-xl max-w-md w-full mx-4 transform transition-all">
              <div className="text-center mb-6">
                <div className="w-16 h-16 mx-auto mb-4 rounded-full bg-[var(--bg-danger)] flex items-center justify-center">
                  <svg xmlns="http://www.w3.org/2000/svg" className="h-8 w-8 text-[var(--text-inverted)]" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                    <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M19 7l-.867 12.142A2 2 0 0116.138 21H7.862a2 2 0 01-1.995-1.858L5 7m5 4v6m4-6v6m1-10V4a1 1 0 00-1-1h-4a1 1 0 00-1 1v3M4 7h16" />
                  </svg>
                </div>
                <h2 className="text-2xl font-bold text-[var(--text-primary)]">Delete User</h2>
                <p className="mt-2 text-[var(--text-secondary)]">Please select a deletion method:</p>
              </div>

              <div className="space-y-4">
                <button
                  className="w-full group p-4 rounded-xl border-2 border-[var(--border-secondary)] hover:border-[var(--warning)] hover:bg-[var(--bg-warning)] hover:bg-opacity-10 transition-all duration-200 focus:outline-none focus:ring-2 focus:ring-[var(--warning)] focus:ring-opacity-50"
                  onClick={handleSoftDelete}
                >
                  <div className="flex items-center gap-3 mb-2">
                    <div className="w-10 h-10 rounded-full bg-[var(--bg-warning)] flex items-center justify-center">
                      <svg xmlns="http://www.w3.org/2000/svg" className="h-5 w-5 text-[var(--text-inverted)]" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M5 8h14M5 8a2 2 0 110-4h14a2 2 0 110 4M5 8v10a2 2 0 002 2h10a2 2 0 002-2V8m-9 4h4" />
                      </svg>
                    </div>
                    <h3 className="font-semibold text-lg text-[var(--text-primary)]">Soft Delete</h3>
                  </div>
                  <p className="text-sm text-[var(--text-secondary)] pl-[52px]">
                    Marks the user as deleted while preserving their data. Can be restored later if needed.
                  </p>
                </button>

                <button
                  className="w-full group p-4 rounded-xl border-2 border-[var(--border-secondary)] hover:border-[var(--error)] hover:bg-[var(--bg-danger)] hover:bg-opacity-10 transition-all duration-200 focus:outline-none focus:ring-2 focus:ring-[var(--error)] focus:ring-opacity-50"
                  onClick={handlePermanentDelete}
                >
                  <div className="flex items-center gap-3 mb-2">
                    <div className="w-10 h-10 rounded-full bg-[var(--bg-danger)] flex items-center justify-center">
                      <svg xmlns="http://www.w3.org/2000/svg" className="h-5 w-5 text-[var(--text-inverted)]" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M19 7l-.867 12.142A2 2 0 0116.138 21H7.862a2 2 0 01-1.995-1.858L5 7m5 4v6m4-6v6m1-10V4a1 1 0 00-1-1h-4a1 1 0 00-1 1v3M4 7h16" />
                      </svg>
                    </div>
                    <h3 className="font-semibold text-lg text-[var(--text-primary)]">Permanent Delete</h3>
                  </div>
                  <p className="text-sm text-[var(--text-secondary)] pl-[52px]">
                    Permanently removes all user data. This action cannot be undone.
                  </p>
                </button>

                <div className="pt-4 flex justify-end">
                  <button
                    onClick={handleCancelDelete}
                    className="px-6 py-2 border-2 border-[var(--border-secondary)] rounded-lg text-[var(--text-primary)] hover:bg-[var(--bg-secondary)] transition-all duration-200 focus:outline-none focus:ring-2 focus:ring-[var(--border-secondary)] focus:ring-opacity-50"
                  >
                    Cancel
                  </button>
                </div>
              </div>
            </div>
          </div>
        )}
      </div>
    </Wrapper>);
};

export default UsersList;
