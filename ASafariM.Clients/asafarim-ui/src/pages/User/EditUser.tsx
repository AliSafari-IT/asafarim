import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { getRoles, getUserById, updateUserByAdmin, assignRolesToUser, removeRolesFromUser, getRolesByUserId } from '../../api/userService';
import { IUser } from '../../interfaces/IUser';
import Wrapper from '../../layout/Wrapper/Wrapper';
import Footer from '../../layout/Footer/Footer';
import Header from '@/layout/Header/Header';
import { debounce } from 'lodash';
import axios from 'axios';
import { Dropdown, IDropdownOption, mergeStyles } from '@fluentui/react';
import { IApiResponse, IRole, IUserRole } from '@/interfaces';
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
    key: role.id.toString(), // Ensure key is string
    text: role.name
  }));

  const handleRoleChange = (
    _event: React.FormEvent<HTMLDivElement>,
    option?: IDropdownOption
  ) => {
    if (option && user) {
      setUser((prev) => {
        const currentRoles = prev?.roles || [];
        const roleId = option.key.toString(); // Ensure string comparison

        const updatedRoles = option.selected
          ? [...currentRoles, roleId]
          : currentRoles.filter((id) => id !== roleId);

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
        const userResponse = await getUserById(id);
        console.log('User response:', userResponse);
        // For single user, response is the direct object
        const userData = userResponse;
        
        if (!userData || !userData.id) {
          throw new Error('User not found');
        }

        if (userData.dateOfBirth) {
          userData.dateOfBirth = new Date(userData.dateOfBirth)
            .toISOString()
            .split('T')[0];
        }

        // Get user's roles
        const rolesResponse = await getRolesByUserId(id);
        console.log('User roles response:', rolesResponse);
        const apiResponse = rolesResponse as IApiResponse<IUserRole>;
        const userRolesArray = apiResponse.$values || apiResponse.value || rolesResponse;
        if (!Array.isArray(userRolesArray)) {
          console.error('Invalid user roles data format:', rolesResponse);
          throw new Error('Invalid user roles data format');
        }
        
        userData.roles = userRolesArray.map(role => role.roleId);
        logger.info(`Fetched user with roles: ${JSON.stringify(userData)}`);
        setUser(userData);
      } catch (err) {
        console.error('Error details:', err);
        logger.error(`Failed to fetch user: ${err}`);
        setError('Failed to load user data.');
      }
    };

    const fetchRoles = async () => {
      try {
        const rolesResponse = await getRoles();
        console.log('Roles response:', rolesResponse);
        const apiResponse = rolesResponse as IApiResponse<IRole>;
        const rolesArray = apiResponse.$values || apiResponse.value || rolesResponse;
        if (!Array.isArray(rolesArray)) {
          console.error('Invalid roles data format:', rolesResponse);
          throw new Error('Invalid roles data format');
        }
        logger.info(`Available roles: ${JSON.stringify(rolesArray)}`);
        setRoles(rolesArray);
      } catch (err) {
        console.error('Error details:', err);
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

      logger.info(`Submitting user data: ${JSON.stringify(user)}`);
      
      // First, update the user's basic information
      const { roles: currentRoles, ...userWithoutRoles } = user;
      
      // Ensure required fields are present
      const updateData = {
        ...userWithoutRoles,
        id: user.id,
        firstName: user.firstName || '',
        lastName: user.lastName || '',
        dateOfBirth: user.dateOfBirth ? new Date(user.dateOfBirth).toISOString() : undefined,
        // Ensure boolean values are properly typed
        isAdmin: typeof user.isAdmin === 'string' ? user.isAdmin === 'true' : !!user.isAdmin,
        isActive: typeof user.isActive === 'string' ? user.isActive === 'true' : !!user.isActive,
        // Only include password if it was changed
        ...(user.password ? { password: user.password } : {})
      };

      logger.info(`Updating user with data: ${JSON.stringify(updateData)}`);
      const updatedUser = await updateUserByAdmin(updateData);
      logger.info(`User update response: ${JSON.stringify(updatedUser)}`);

      if (updatedUser) {
        // Get the current roles for comparison
        const rolesResponse = await getRolesByUserId(user.id);
        const apiResponse = rolesResponse as IApiResponse<IUserRole>;
        const userRolesArray = apiResponse.$values || apiResponse.value || rolesResponse;
        if (!Array.isArray(userRolesArray)) {
          throw new Error('Invalid user roles data format');
        }
        const existingRoles = userRolesArray.map(role => role.roleId);

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
      console.error('Error updating user:', error);
      logger.error(`Error updating user: ${error}`);
      if (axios.isAxiosError(error)) {
        setError(`Failed to update user: ${error.response?.data?.message || error.message}`);
      } else {
        setError('An unexpected error occurred while updating the user.');
      }
    }
  };

  const dropdownStyles = mergeStyles({
    dropdown: {
      width: '100%',
      minWidth: 200,
    },
    title: {
      backgroundColor: 'var(--dropdown-bg)',
      borderColor: 'var(--dropdown-border)',
      ':hover': {
        backgroundColor: 'var(--dropdown-hover)',
      },
    },
    caretDown: {
      color: 'var(--text-primary)',
    },
    dropdownItemSelected: {
      backgroundColor: 'var(--dropdown-hover)',
    },
  });

  // Determine if form fields should be disabled
  const isFormDisabled = user?.isDeleted || false;

  if (!user) return <p>Loading...</p>;

  return (
    <Wrapper
      header={<Header children={<h1 className="text-2xl font-semibold text-[var(--text-info)]">Edit User</h1>} />}
      footer={<Footer />}
    >
      <div className="w-full max-w-6xl mx-auto px-4 sm:px-6 lg:px-8 py-4 sm:py-6">
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
              {user?.isDeleted ? 'View Deleted User' : 'Edit User'}
            </h1>
          </div>
        </div>

        {error && (
          <div className="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded relative mb-4" role="alert">
            <span className="block sm:inline">{error}</span>
          </div>
        )}

        {user?.isDeleted && (
          <div className="bg-yellow-100 border border-yellow-400 text-yellow-700 px-4 py-3 rounded relative mb-4" role="alert">
            <span className="font-bold">Note:</span>
            <span className="block sm:inline"> This account has been deleted. You can view the details but cannot make changes. The account must be reactivated before any updates can be made.</span>
          </div>
        )}
        
        <div className="bg-white dark:bg-gray-800 shadow-lg rounded-lg p-4 sm:p-6 lg:p-8 transition-colors duration-200">
          <form onSubmit={handleSubmit} className="space-y-6">
            <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
              {isLoggedInUserAdmin && (
                <div className="md:col-span-2 p-4 bg-blue-50 dark:bg-blue-900/20 rounded-lg border border-blue-200 dark:border-blue-800">
                  <label className="block text-sm font-medium text-blue-700 dark:text-blue-300 mb-2">Assign Roles:</label>
                  <Dropdown
                    placeholder="Select roles"
                    multiSelect
                    options={roleOptions}
                    onChange={handleRoleChange}
                    selectedKeys={user.roles?.map(r => r.toString()) || []}
                    disabled={isFormDisabled}
                    styles={{
                      root: dropdownStyles,
                      dropdown: {
                        minWidth: 200,
                      },
                    }}
                  />
                </div>
              )}
              
              {/* First Name */}
              <div className="space-y-2">
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm font-medium">
                  First Name
                </label>
                <input
                  type="text"
                  name="firstName"
                  value={user.firstName || ''}
                  onChange={handleInputChange}
                  disabled={isFormDisabled}
                  className={`w-full px-4 py-2 ${isFormDisabled ? 'bg-gray-100 dark:bg-gray-800 cursor-not-allowed' : 'bg-white dark:bg-gray-700'} text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200`}
                />
              </div>

              {/* Last Name */}
              <div className="space-y-2">
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm font-medium">
                  Last Name
                </label>
                <input
                  type="text"
                  name="lastName"
                  value={user.lastName || ''}
                  onChange={handleInputChange}
                  disabled={isFormDisabled}
                  className={`w-full px-4 py-2 ${isFormDisabled ? 'bg-gray-100 dark:bg-gray-800 cursor-not-allowed' : 'bg-white dark:bg-gray-700'} text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200`}
                />
              </div>

              {/* User Name */}
              <div className="space-y-2">
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm font-medium">
                  User Name
                </label>
                <input
                  type="text"
                  name="userName"
                  value={user.userName || ''}
                  onChange={handleInputChange}
                  disabled={isFormDisabled}
                  className={`w-full px-4 py-2 ${isFormDisabled ? 'bg-gray-100 dark:bg-gray-800 cursor-not-allowed' : 'bg-white dark:bg-gray-700'} text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200`}
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
              <div className="space-y-2">
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm font-medium">
                  Email
                </label>
                <input
                  type="email"
                  name="email"
                  value={user.email || ''}
                  onChange={handleInputChange}
                  disabled={isFormDisabled}
                  className={`w-full px-4 py-2 ${isFormDisabled ? 'bg-gray-100 dark:bg-gray-800 cursor-not-allowed' : 'bg-white dark:bg-gray-700'} text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200`}
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
              <div className="space-y-2">
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm font-medium">Date of Birth</label>
                <input
                  type="date"
                  name="dateOfBirth"
                  value={user.dateOfBirth || ''}
                  onChange={handleInputChange}
                  disabled={isFormDisabled}
                  className={`w-full px-4 py-2 ${isFormDisabled ? 'bg-gray-100 dark:bg-gray-800 cursor-not-allowed' : 'bg-white dark:bg-gray-700'} text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200`}
                />
              </div>

              {/* Profile Picture */}
              <div className="space-y-2">
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm font-medium">Profile Picture URL</label>
                <input
                  type="text"
                  name="profilePicture"
                  value={user.profilePicture || ''}
                  onChange={handleInputChange}
                  disabled={isFormDisabled}
                  className={`w-full px-4 py-2 ${isFormDisabled ? 'bg-gray-100 dark:bg-gray-800 cursor-not-allowed' : 'bg-white dark:bg-gray-700'} text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200`}
                />
              </div>

              {/* Remark */}
              <div className="space-y-2">
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm font-medium">Remark</label>
                <input
                  type="text"
                  name="remark"
                  value={user.remark || ''}
                  onChange={handleInputChange}
                  disabled={isFormDisabled}
                  className={`w-full px-4 py-2 ${isFormDisabled ? 'bg-gray-100 dark:bg-gray-800 cursor-not-allowed' : 'bg-white dark:bg-gray-700'} text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200`}
                />
              </div>

              {/* Biography */}
              <div className="md:col-span-2 space-y-2">
                <label className="block text-[var(--text-info)] dark:text-[var(--info)] text-sm font-medium">Biography</label>
                <textarea
                  name="biography"
                  value={user.biography || ''}
                  onChange={handleInputChange}
                  disabled={isFormDisabled}
                  className={`w-full px-4 py-2 ${isFormDisabled ? 'bg-gray-100 dark:bg-gray-800 cursor-not-allowed' : 'bg-white dark:bg-gray-700'} text-gray-900 dark:text-gray-100 border border-gray-300 dark:border-gray-600 rounded-lg focus:outline-none focus:ring-2 focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200`}
                  rows={4}
                ></textarea>
              </div>
            </div>

            {/* Checkboxes in a nice card */}
            <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
              <div className="p-4 bg-gray-50 dark:bg-gray-700/50 rounded-lg border border-gray-200 dark:border-gray-700">
                <div className="flex items-center space-x-3">
                  <input
                    type="checkbox"
                    name="isAdmin"
                    checked={user.isAdmin || false}
                    onChange={(e) => {
                      setUser({
                        ...user,
                        isAdmin: e.target.checked
                      });
                    }}
                    disabled={isFormDisabled}
                    className={`w-5 h-5 text-[var(--info)] dark:text-[var(--info)] ${isFormDisabled ? 'bg-gray-100 dark:bg-gray-800 cursor-not-allowed' : 'bg-white dark:bg-gray-600'} border-gray-300 dark:border-gray-500 rounded focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200`}
                  />
                  <label className="text-gray-700 dark:text-gray-200 text-sm font-medium">Administrator Access</label>
                </div>
                <p className="text-xs text-gray-500 dark:text-gray-400 mt-2 ml-8">
                  Grants full administrative privileges to manage all aspects of the system
                </p>
              </div>

              <div className="p-4 bg-gray-50 dark:bg-gray-700/50 rounded-lg border border-gray-200 dark:border-gray-700">
                <div className="flex items-center space-x-3">
                  <input
                    type="checkbox"
                    name="isActive"
                    checked={user.isDeleted ? false : (user.isActive || false)}
                    disabled={user.isDeleted || isFormDisabled}
                    onChange={(e) => {
                      setUser({
                        ...user,
                        isActive: e.target.checked
                      });
                    }}
                    className={`w-5 h-5 text-[var(--info)] dark:text-[var(--info)] ${isFormDisabled ? 'bg-gray-100 dark:bg-gray-800 cursor-not-allowed' : 'bg-white dark:bg-gray-600'} border-gray-300 dark:border-gray-500 rounded focus:ring-[var(--info)] dark:focus:ring-[var(--info)] transition-colors duration-200`}
                  />
                  <label className="text-gray-700 dark:text-gray-200 text-sm font-medium">Active Account</label>
                </div>
                <p className="text-xs text-gray-500 dark:text-gray-400 mt-2 ml-8">
                  {user.isDeleted 
                    ? "This account has been deleted and cannot be activated" 
                    : "Determines whether this user can log in and access the system"}
                </p>
              </div>
            </div>

            <div className="flex justify-end space-x-4 pt-4 border-t border-gray-200 dark:border-gray-700">
              <button
                type="button"
                onClick={() => navigate('/users')}
                className="px-5 py-2.5 bg-gray-200 dark:bg-gray-700 text-gray-700 dark:text-gray-300 rounded-lg hover:bg-gray-300 dark:hover:bg-gray-600 focus:outline-none focus:ring-2 focus:ring-gray-400 transition-colors duration-200"
              >
                {user?.isDeleted ? 'Back' : 'Cancel'}
              </button>
              {!user?.isDeleted && (
                <button
                  type="submit"
                  className="px-5 py-2.5 bg-[var(--info)] dark:bg-[var(--info-dark)] text-white rounded-lg hover:bg-[var(--info-dark)] dark:hover:bg-[var(--info-dark)] focus:outline-none focus:ring-2 focus:ring-[var(--info)] transition-colors duration-200"
                >
                  Save Changes
                </button>
              )}
            </div>
          </form>
        </div>
      </div>
    </Wrapper>
  );
};

export default EditUser;
