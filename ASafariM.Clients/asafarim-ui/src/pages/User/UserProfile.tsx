import React, { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { getUserById } from '@/api/userService';
import useAuth from '@/hooks/useAuth';
import { IUser } from '@/interfaces';

const UserProfile: React.FC = () => {
    const [userInfo, setUserInfo] = useState<IUser | null>(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState<string | null>(null);
    const { authenticatedUser, authenticated, token } = useAuth();
    const [isActive, setIsActive] = useState(false);
    const navigate = useNavigate();

    useEffect(() => {
        if (!authenticated || !authenticatedUser || !token) {
            navigate('/');
            return;
        }

        const fetchUserInfo = async () => {
            try {
                setLoading(true);
                const data = await getUserById(authenticatedUser.id);
                setUserInfo(data);
            } catch (err) {
                console.error('Error fetching user information:', err);
                setError('Unable to fetch user information.');
            } finally {
                setLoading(false);
            }
        };

        fetchUserInfo();
    }, [authenticated, authenticatedUser, token, navigate]);

    useEffect(
        () => {
            if (userInfo) {
                console.log('UserProfile: userInfo', userInfo);
                console.log('UserProfile: lastLogin value', userInfo.lastLogin);
                console.log('UserProfile: lastLogin type', typeof userInfo.lastLogin);
                setIsActive(userInfo.isActive ?? false);
            }
        }, [userInfo]);

    if (loading) {
        return (
            <div className="flex items-center justify-center h-screen">
                <div className="animate-spin rounded-full h-12 w-12 border-t-2 border-b-2 border-gray-900 dark:border-gray-100"></div>
            </div>
        );
    }

    if (error) {
        return (
            <div className="flex items-center justify-center h-screen">
                <p className="text-red-600 dark:text-red-400">{error}</p>
            </div>
        );
    }

    if (!userInfo) {
        return (
            <div className="flex items-center justify-center h-screen">
                <p className="text-gray-500 dark:text-gray-400">User information is not available.</p>
            </div>
        );
    }

    return (
        <div className="max-w-4xl mx-auto p-6">
            <div className="space-y-6">
                <div className="flex items-center justify-between pb-6">
                    <h2 className="text-2xl font-bold text-gray-800 dark:text-gray-200">User Profile</h2>
                    <div className="flex items-center space-x-2">
                        <div className="w-12 h-12 rounded-full bg-gradient-to-r from-blue-500 to-teal-500 flex items-center justify-center text-white text-xl font-bold">
                            {userInfo.firstName?.charAt(0).toUpperCase() || '-'}
                        </div>
                    </div>
                </div>

                <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
                    {/* Personal Information */}
                    <div className="bg-white dark:bg-gray-800 rounded-lg shadow-md p-6">
                        <h3 className="text-lg font-semibold mb-4 text-gray-800 dark:text-gray-200">Personal Information</h3>
                        <div className="space-y-4">
                            <div>
                                <label className="block text-sm font-medium text-gray-500 dark:text-gray-400">First Name</label>
                                <p className="mt-1 text-gray-800 dark:text-gray-200">{userInfo.firstName || 'N/A'}</p>
                            </div>
                            <div>
                                <label className="block text-sm font-medium text-gray-500 dark:text-gray-400">Last Name</label>
                                <p className="mt-1 text-gray-800 dark:text-gray-200">{userInfo.lastName || 'N/A'}</p>
                            </div>
                            <div>
                                <label className="block text-sm font-medium text-gray-500 dark:text-gray-400">Email</label>
                                <p className="mt-1 text-gray-800 dark:text-gray-200">{userInfo.email || 'N/A'}</p>
                            </div>
                        </div>
                    </div>

                    {/* Account Details */}
                    <div className={"bg-white dark:bg-gray-800 rounded-lg shadow-md p-6 col-span-2 sm:col-span-1 "+ (userInfo.isAdmin ? 'border-x-4 border-blue-500' : 'border-x-4 border-gray-500')}>
                        <h3 className="text-lg font-semibold mb-4 text-gray-800 dark:text-gray-200">Account Details</h3>
                        <div className="space-y-4">
                            <div className='w-full'>
                                <label className="block text-sm font-medium text-gray-500 dark:text-gray-400">User ID</label>
                                <p className="mt-1 text-sm text-gray-800 dark:text-gray-200 font-mono">{userInfo.id || 'N/A'}</p>
                            </div>
                            <div className='w-full flex justify-between'>
                                <div className='w-full'>
                                    <label className="block text-sm font-medium text-gray-500 dark:text-gray-400">Is Admin</label>
                                    <p className="mt-1 text-gray-800 dark:text-gray-200 font-semibold">{userInfo.isAdmin ? 'Yes' : 'No'}</p>
                                </div>
                                <div className='w-full'>
                                    {isActive === true ? (
                                        <div className="bg-green-300 dark:bg-green-800 text-center rounded-full px-2 py-1 mt-1 text-gray-800 font-semibold dark:text-yellow-100">
                                            Active User
                                        </div>
                                    ) : (
                                        <div className="bg-red-200 dark:bg-red-800 text-center rounded-full px-2 py-1 mt-1 text-gray-800 font-semibold dark:text-yellow-400">
                                            Inactive User
                                        </div>
                                    )}
                                </div>
                            </div>
                            <div>
                                <label className="block text-sm font-medium text-gray-500 dark:text-gray-400">Date Created</label>
                                <p className="mt-1 text-gray-800 dark:text-gray-200">{userInfo.createdAt && new Date(userInfo.createdAt).toLocaleString() || 'N/A'}</p>
                            </div>
                            <div>
                                <label className="block text-sm font-medium text-gray-500 dark:text-gray-400">Date Modified</label>
                                <p className="mt-1 text-gray-800 dark:text-gray-200">{userInfo.updatedAt && new Date(userInfo.updatedAt).toLocaleString() || 'N/A'}</p>
                            </div>
                            <div>
                                <label className="block text-sm font-medium text-gray-500 dark:text-gray-400">Last Login</label>
                                <p className="mt-1 text-gray-800 dark:text-gray-200">
                                    {userInfo.lastLogin && userInfo.lastLogin !== '0001-01-01T00:00:00' 
                                        ? new Date(userInfo.lastLogin).toLocaleString() 
                                        : 'N/A'}
                                </p>
                            </div>
                            <div>
                                <label className="block text-sm font-medium text-gray-500 dark:text-gray-400">Is Deleted</label>
                                <p className="mt-1 text-gray-800 dark:text-gray-200">{userInfo.isDeleted ? `Yes (${userInfo.deletedAt?.toLocaleString()})` : 'No'}</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default UserProfile;
