import React, { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { useAuth } from '@/contexts/AuthContext';
import { getUserById } from '@/api/userService';
import { IUser } from '@/interfaces';
import Wrapper from '@/layout/Wrapper/Wrapper';
import Header from '@/layout/Header/Header';
import Footer from '@/layout/Footer/Footer';
import { logger } from '@/utils/logger';

const UserProfile: React.FC = () => {
    const [userInfo, setUserInfo] = useState<IUser | null>(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState<string | null>(null);
    const { authenticatedUser, authenticated, token } = useAuth();
    const [_isActive, setIsActive] = useState(false);
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
                console.log('Received dateOfBirth from API:', data.dateOfBirth, _isActive); // <--- Add this line
                setUserInfo(data);
            } catch (err) {
                logger.error('Error fetching user information:', err);
                setError('Unable to fetch user information.');
            } finally {
                setLoading(false);
            }
        };

        fetchUserInfo();
    }, [authenticated, authenticatedUser, token, navigate, _isActive]);

    useEffect(
        () => {
            if (userInfo) {
                logger.info('UserProfile: userInfo', userInfo);
                logger.info('UserProfile: lastLogin value', userInfo.lastLogin);
                logger.info('UserProfile: lastLogin type', typeof userInfo.lastLogin);
                setIsActive(userInfo.isActive ?? false);
            }
        }, [userInfo]);

    // Generate user avatar initials
    const getUserInitials = () => {
        if (!userInfo) return '';
        const firstInitial = userInfo.firstName ? userInfo.firstName.charAt(0).toUpperCase() : '';
        const lastInitial = userInfo.lastName ? userInfo.lastName.charAt(0).toUpperCase() : '';
        return `${firstInitial}${lastInitial}`;
    };

    if (loading) {
        return (
            <Wrapper header={<Header />} footer={<Footer />}>
                <div className="flex justify-center items-center h-[70vh]">
                    <div className="animate-spin rounded-full h-16 w-16 border-t-2 border-b-2 border-[var(--info)]"></div>
                </div>
            </Wrapper>
        );
    }

    if (error) {
        return (
            <Wrapper header={<Header />} footer={<Footer />}>
                <div className="flex items-center justify-center h-[70vh]">
                    <div className="bg-red-100 border border-red-400 text-red-700 px-6 py-4 rounded-lg max-w-lg">
                        <p className="font-medium">{error}</p>
                    </div>
                </div>
            </Wrapper>
        );
    }

    if (!userInfo) {
        return (
            <Wrapper header={<Header />} footer={<Footer />}>
                <div className="flex items-center justify-center h-[70vh]">
                    <div className="bg-yellow-100 border border-yellow-400 text-yellow-700 px-6 py-4 rounded-lg max-w-lg">
                        <p className="font-medium">User information is not available.</p>
                    </div>
                </div>
            </Wrapper>
        );
    }

    return (
        <Wrapper header={<Header />} footer={<Footer />}>
            <div className="container mx-auto px-4 py-8 max-w-5xl">
                <div className="flex items-center justify-between mb-6">
                    <div>

                        <h1 className="text-2xl font-bold text-gray-800 dark:text-gray-100 mt-2">
                            My Profile
                        </h1>
                    </div>
                </div>

                {userInfo.isDeleted && (
                    <div className="bg-yellow-100 border border-yellow-400 text-yellow-700 px-4 py-3 rounded relative mb-4" role="alert">
                        <span className="font-bold">Note:</span>
                        <span className="block sm:inline"> Your account has been deleted. Please contact an administrator for reactivation.</span>
                    </div>
                )}

                <div className="bg-white dark:bg-gray-800 shadow-lg rounded-lg overflow-hidden">
                    {/* User Header with Avatar */}
                    <div className="bg-gradient-to-r from-[var(--info-light)] to-[var(--info)] p-6 flex items-center">
                        {userInfo.profilePicture ? (
                            <img 
                                src={userInfo.profilePicture} 
                                alt={`${userInfo.firstName} ${userInfo.lastName}`}
                                className="w-20 h-20 rounded-full object-cover border-4 border-white shadow-md" 
                            />
                        ) : (
                            <div className="w-20 h-20 rounded-full bg-white text-[var(--info)] flex items-center justify-center text-2xl font-bold border-4 border-white shadow-md">
                                {getUserInitials()}
                            </div>
                        )}
                        <div className="ml-6 text-white">
                            <h2 className="text-2xl font-bold">{userInfo.firstName} {userInfo.lastName}</h2>
                            <p className="opacity-90">{userInfo.userName || userInfo.email}</p>
                            <div className="flex mt-2 space-x-2">
                                <span className={`px-2 py-1 text-xs rounded-full font-medium ${userInfo.isAdmin ? 'bg-purple-200 text-purple-800' : 'bg-gray-200 text-gray-800'}`}>
                                    {userInfo.isAdmin ? 'Administrator' : 'Standard User'}
                                </span>
                                <span className={`px-2 py-1 text-xs rounded-full font-medium ${
                                    userInfo.isDeleted 
                                        ? 'bg-red-200 text-red-800' 
                                        : (userInfo.isActive ? 'bg-green-200 text-green-800' : 'bg-yellow-200 text-yellow-800')
                                }`}>
                                    {userInfo.isDeleted ? 'Deleted' : (userInfo.isActive ? 'Active' : 'Inactive')}
                                </span>
                            </div>
                        </div>
                    </div>

                    {/* User Details */}
                    <div className="p-6">
                        <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
                            {/* Personal Information Section */}
                            <div className="space-y-4 col-span-2">
                                <h3 className="text-lg font-semibold text-gray-800 dark:text-gray-200 border-b border-gray-200 dark:border-gray-700 pb-2">
                                    Personal Information
                                </h3>
                                <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
                                    {/* First Name */}
                                    <div className="space-y-2">
                                        <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">First Name</h3>
                                        <p className="text-gray-700 dark:text-gray-300">{userInfo.firstName || 'N/A'}</p>
                                    </div>

                                    {/* Last Name */}
                                    <div className="space-y-2">
                                        <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Last Name</h3>
                                        <p className="text-gray-700 dark:text-gray-300">{userInfo.lastName || 'N/A'}</p>
                                    </div>

                                    {/* Email */}
                                    <div className="space-y-2">
                                        <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Email</h3>
                                        <p className="text-gray-700 dark:text-gray-300">{userInfo.email || 'N/A'}</p>
                                    </div>

                                    {/* Username */}
                                    <div className="space-y-2">
                                        <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Username</h3>
                                        <p className="text-gray-700 dark:text-gray-300">{userInfo.userName || 'N/A'}</p>
                                    </div>
                                </div>
                            </div>

                            {/* Account Details Section */}
                            <div className="space-y-4 col-span-2">
                                <h3 className="text-lg font-semibold text-gray-800 dark:text-gray-200 border-b border-gray-200 dark:border-gray-700 pb-2">
                                    Account Details
                                </h3>
                                <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
                                    {/* User ID */}
                                    <div className="space-y-2">
                                        <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">User ID</h3>
                                        <p className="text-gray-700 dark:text-gray-300 font-mono text-sm">{userInfo.id || 'N/A'}</p>
                                    </div>

                                    {/* Account Status */}
                                    <div className="space-y-2">
                                        <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Account Status</h3>
                                        <div className="flex items-center">
                                            <span className={`inline-block w-3 h-3 rounded-full mr-2 ${
                                                userInfo.isDeleted 
                                                    ? 'bg-red-500' 
                                                    : (userInfo.isActive ? 'bg-green-500' : 'bg-yellow-500')
                                            }`}></span>
                                            <p className="text-gray-700 dark:text-gray-300">
                                                {userInfo.isDeleted ? 'Deleted' : (userInfo.isActive ? 'Active' : 'Inactive')}
                                            </p>
                                        </div>
                                    </div>

                                    {/* Date Created */}
                                    <div className="space-y-2">
                                        <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Date Created</h3>
                                        <p className="text-gray-700 dark:text-gray-300">
                                            {userInfo.createdAt && new Date(userInfo.createdAt).toLocaleString() || 'N/A'}
                                        </p>
                                    </div>

                                    {/* Date Modified */}
                                    <div className="space-y-2">
                                        <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Date Modified</h3>
                                        <p className="text-gray-700 dark:text-gray-300">
                                            {userInfo.updatedAt && new Date(userInfo.updatedAt).toLocaleString() || 'N/A'}
                                        </p>
                                    </div>

                                    {/* Last Login */}
                                    <div className="space-y-2">
                                        <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Last Login</h3>
                                        <p className="text-gray-700 dark:text-gray-300">
                                            {userInfo.lastLogin && userInfo.lastLogin !== '0001-01-01T00:00:00' 
                                                ? new Date(userInfo.lastLogin).toLocaleString() 
                                                : 'N/A'}
                                        </p>
                                    </div>

                                    {/* Admin Status */}
                                    <div className="space-y-2">
                                        <h3 className="text-sm font-medium text-[var(--text-info)] dark:text-[var(--info)]">Admin Status</h3>
                                        <div className="flex items-center">
                                            <span className={`inline-block w-3 h-3 rounded-full mr-2 ${userInfo.isAdmin ? 'bg-purple-500' : 'bg-gray-500'}`}></span>
                                            <p className="text-gray-700 dark:text-gray-300">
                                                {userInfo.isAdmin ? 'Administrator' : 'Standard User'}
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </Wrapper>
    );
};

export default UserProfile;
