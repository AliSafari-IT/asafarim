import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { getRoles, getUserById, updateUserByAdmin, assignRolesToUser, removeRolesFromUser, getRolesByUserId } from '../../api/userService';
import { IUser } from '../../interfaces/IUser';
import Wrapper from '../../layout/Wrapper/Wrapper';
import Footer from '../../layout/Footer/Footer';
import Header from '@/layout/Header/Header';
import { debounce } from 'lodash';
import axios from 'axios';
import { Dropdown, IDropdownOption } from '@fluentui/react';
import { IRole } from '@/interfaces';
import useAuth from '@/hooks/useAuth';
import { logger } from '@/utils/logger';

const EditUser: React.FC = () => {
  const { id } = useParams<{ id: string }>();
  const navigate = useNavigate();

  const [roles, setRoles] = useState<IRole[]>([]);
  const [user, setUser] = useState<IUser | null>({} as IUser);
  const [error, setError] = useState<string | null>(null);
  const { authenticatedUser } = useAuth();
  const [isLoggedInUserAdmin, setIsLoggedInUserAdmin] = useState<boolean>(false);

  // For availability checks
  const [usernameAvailable, setUsernameAvailable] = useState<boolean | null>(null);
  const [emailAvailable, setEmailAvailable] = useState<boolean | null>(null);

  useEffect(() => {
    setIsLoggedInUserAdmin(authenticatedUser?.isAdmin || false);
  }, [authenticatedUser]);

  const roleOptions = roles.map((role) => ({
    key: role.id,
    text: role.name,
  }));

  const handleRoleChange = (
    _event: React.FormEvent<HTMLDivElement>,
    option?: IDropdownOption,
    index?: number
  ) => {
    if (option && user) {
      setUser((prev) => {
        // Initialize roles array if it doesn't exist
        const currentRoles = prev?.roles || [];

        // Convert option.key to string to match IUser interface
        const roleId = String(option.key);

        // Update roles based on selection
        const updatedRoles = option.selected
          ? [...currentRoles, roleId] // Add role
          : currentRoles.filter((id) => id !== roleId); // Remove role
        logger.info(`Updated roles in user: ${JSON.stringify(updatedRoles)}`);
        if (index !== undefined) {
          logger.info(`Index: ${index}`);
        }

        return {
          ...prev!,
          roles: updatedRoles
        };
      });
    }
  };

  // Debounced check
  const checkAvailability = debounce(async (field: 'userName' | 'email', value: string) => {
    if (!value) return; // skip empty

    try {
      const queryParam = field === 'userName' ? { username: value } : { email: value };
      const response = await axios.get('/api/users/check-availability/validate', {
        params: queryParam
      });
      const { isAvailable } = response.data;

      if (field === 'userName') {
        setUsernameAvailable(isAvailable);
      } else {
        setEmailAvailable(isAvailable);
      }
    } catch (err) {
      logger.error(`Availability check failed: ${err}`);
    }
  }, 500);

  useEffect(() => {
    const fetchUser = async () => {
      if (!id) return;
      try {
        const fetchedUser = await getUserById(id);
        if (fetchedUser.dateOfBirth) {
          fetchedUser.dateOfBirth = new Date(fetchedUser.dateOfBirth)
            .toISOString()
            .split('T')[0];
        }

        // Get user's roles
        const userRoles = await getRolesByUserId(id);
        fetchedUser.roles = userRoles.map(role => role.roleId);
        logger.info(`Fetched user with roles: ${JSON.stringify(fetchedUser)}`);
        setUser(fetchedUser);
      } catch (err) {
        logger.error(`Failed to fetch user: ${err}`);
        setError('Failed to load user data.');
      }
    };

    const fetchRoles = async () => {
      try {
        const fetchedRoles = await getRoles();
        logger.info(`Available roles: ${JSON.stringify(fetchedRoles)}`);
        setRoles(fetchedRoles);
      } catch (err) {
        logger.error(`Failed to fetch roles: ${err}`);
        setError('Failed to load roles.');
      }
    };

    fetchUser();
    fetchRoles();
  }, [id]);

  useEffect(() => {
    if (user?.roles) {
      logger.info(`Initial user roles: ${JSON.stringify(user.roles)}`);
    }
  }, [user?.roles]);

  const handleInputChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    if (!user) return;

    const target = e.target as HTMLInputElement;
    let value = target.type === 'checkbox' ? String(target.checked) : target.value;

    // Special handling for date input
    if (target.type === 'date') {
      // The value is already in YYYY-MM-DD format from the input
      // Just store it as is for display, we'll convert to ISO in handleSubmit
      value = `${value}`;
    }

    const name = target.name;

    // If user changes username or email, do the availability check
    if (name === 'userName') {
      checkAvailability('userName', value);
    } else if (name === 'email') {
      checkAvailability('email', value);
    }

    setUser({
      ...user,
      [name]: value,
    });
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();

    try {
      if (!user) return;

      logger.info(`User data: ${JSON.stringify(user)}`);
      const newRole = user.roles?.[0] || ''; // Assuming the first role is the one to update
      logger.info(`Role changed to: ${newRole}`);
      // First, update the user's basic information
      const { roles: currentRoles, ...userWithoutRoles } = user;
      const updatedUser = await updateUserByAdmin({
        ...userWithoutRoles,
        dateOfBirth: user.dateOfBirth ? new Date(user.dateOfBirth).toISOString() : undefined,
        password: user.password ?? "P@ssw0rd+",
      });

      if (updatedUser) {
        // Get the current roles for comparison
        const existingRoles = (await getRolesByUserId(user.id)).map(role => role.roleId);

        // Determine which roles to add and remove
        const rolesToAdd = currentRoles?.filter(role => !existingRoles.includes(role)) || [];
        const rolesToRemove = existingRoles.filter(role => !currentRoles?.includes(role));

        logger.info(`Roles to add: ${JSON.stringify(rolesToAdd)}`);
        logger.info(`Roles to remove: ${JSON.stringify(rolesToRemove)}`);

        // Update roles if necessary
        if (rolesToAdd.length > 0) {
          await assignRolesToUser(user.id, rolesToAdd);
        }
        if (rolesToRemove.length > 0) {
          await removeRolesFromUser(user.id, rolesToRemove);
        }

        navigate('/users/view/' + updatedUser.id);
      }
    } catch (error) {
      logger.error(`Error updating user: ${error}`);
      if (axios.isAxiosError(error)) {
        logger.error(`Error response: ${JSON.stringify(error.response?.data)}`);
        setError(error.response?.data?.message || 'Failed to update user. Please try again.');
      } else {
        setError('Failed to update user. Please try again.');
      }
    }
  };

  if (!user) return <p>Loading...</p>;

  return (
    <Wrapper
      header={<Header children={<h1 className="text-2xl font-semibold text-[var(--text-info)]">Edit User</h1>} />}
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
            User Management
          </h1>
          <form onSubmit={handleSubmit} className="space-y-4 sm:space-y-6">
            <div className="grid grid-cols-1 md:grid-cols-2 gap-4 sm:gap-6">
              {isLoggedInUserAdmin && (
                <div>
                  <label>Assign Roles:</label>
                  <Dropdown
                    placeholder="Select roles"
                    multiSelect
                    options={roleOptions}
                    onChange={handleRoleChange}
                    selectedKeys={user.roles}
                  />
                </div>
              )}
              {/* First Name */}
              <div>
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                  First Name
                </label>
                <input
                  type="text"
                  name="firstName"
                  value={user.firstName || ''}
                  onChange={handleInputChange}
                  className="w-full px-3 sm:px-4 py-2 bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200"
                />
              </div>

              {/* Last Name */}
              <div>
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                  Last Name
                </label>
                <input
                  type="text"
                  name="lastName"
                  value={user.lastName || ''}
                  onChange={handleInputChange}
                  className="w-full px-3 sm:px-4 py-2 bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200"
                />
              </div>

              {/* User Name */}
              <div>
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                  User Name
                </label>
                <input
                  type="text"
                  name="userName"
                  value={user.userName || ''}
                  onChange={handleInputChange}
                  className="w-full px-3 sm:px-4 py-2 bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200"
                />
                {/* Feedback message */}
                {usernameAvailable !== null && (
                  <p className={`text-sm mt-1 ${usernameAvailable ? 'text-green-500' : 'text-red-500'}`}>
                    {usernameAvailable
                      ? 'Username is available'
                      : 'Username is already taken'}
                  </p>
                )}
              </div>

              {/* Email */}
              <div>
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">
                  Email
                </label>
                <input
                  type="email"
                  name="email"
                  value={user.email || ''}
                  onChange={handleInputChange}
                  className="w-full px-3 sm:px-4 py-2 bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200"
                />
                {/* Feedback message */}
                {emailAvailable !== null && (
                  <p className={`text-sm mt-1 ${emailAvailable ? 'text-green-500' : 'text-red-500'}`}>
                    {emailAvailable
                      ? 'Email is available'
                      : 'Email is already registered'}
                  </p>
                )}
              </div>

              {/* Date of Birth */}
              <div>
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">Date of Birth</label>
                <input
                  type="date"
                  name="dateOfBirth"
                  value={user.dateOfBirth || ''}
                  onChange={handleInputChange}
                  className="w-full px-3 sm:px-4 py-2 bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200"
                />
              </div>

              {/* Profile Picture */}
              <div>
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">Profile Picture</label>
                <input
                  type="text"
                  name="profilePicture"
                  value={user.profilePicture || ''}
                  onChange={handleInputChange}
                  className="w-full px-3 sm:px-4 py-2 bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200"
                />
              </div>

              {/* Remark */}
              <div>
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">Remark</label>
                <input
                  type="text"
                  name="remark"
                  value={user.remark || ''}
                  onChange={handleInputChange}
                  className="w-full px-3 sm:px-4 py-2 bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200"
                />
              </div>

              {/* Biography */}
              <div className="col-span-2">
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base mb-2">Biography</label>
                <textarea
                  name="biography"
                  value={user.biography || ''}
                  onChange={handleInputChange}
                  className="w-full px-3 sm:px-4 py-2 bg-white dark:bg-gray-700 text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200"
                  rows={4}
                ></textarea>
              </div>
            </div>

            {/* Admin Status */}
            <div className="flex items-center space-x-2">
              <input
                type="checkbox"
                name="isAdmin"
                checked={user.isAdmin || false}
                onChange={handleInputChange}
                className="w-4 h-4 text-[var(--info)] dark:text-[var(--info)] bg-white dark:bg-gray-700 border-gray-300 dark:border-gray-600 rounded focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200"
              />
              <label className="text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base">Is Admin</label>
            </div>

            {/* Active Status */}
            <div className="flex items-center space-x-2">
              <input
                type="checkbox"
                name="isActive"
                checked={user.isActive || false}
                onChange={handleInputChange}
                className="w-4 h-4 text-[var(--info)] dark:text-[var(--info)] bg-white dark:bg-gray-700 border-gray-300 dark:border-gray-600 rounded focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200"
              />
              <label className="text-[var(--text-info)] dark:text-[var(--info)] text-sm sm:text-base">Is Active</label>
            </div>

            <div className="flex justify-end space-x-4">
              <button
                type="button"
                onClick={() => navigate('/users')}
                className="px-4 py-2 bg-[var(--secondary)] dark:bg-[var(--secondary-dark)] text-white rounded-lg hover:bg-[var(--tertiary-light)] dark:hover:bg-[var(--tertiary-dark)] focus:outline-none focus:ring-2 focus:ring-[var(--secondary)] transition-colors duration-200"
              >
                Cancel
              </button>
              <button
                type="submit"
                className="px-4 py-2 bg-[var(--info)] dark:bg-[var(--info-dark)] text-white rounded-lg hover:bg-[var(--info-dark)] dark:hover:bg-[var(--info-dark)] focus:outline-none focus:ring-2 focus:ring-[var(--info)] transition-colors duration-200"
              >
                Update User
              </button>
            </div>
          </form>
        </div>
      </div>
    </Wrapper>
  );
};

export default EditUser;
