import { updateUserProfile } from '@/api/authapi';
import { IUserModelUpdate } from '@/interfaces';
import { IUserInfo } from '@/interfaces/IUserInfo';

const handleUpdateProfile = async (
    authenticatedUser: IUserInfo,
    email: string,
    firstName: string,
    lastName: string,
    setMessage: (message: { type: string, text: string }) => void,
    setLoading: (loading: boolean) => void
) => {
    console.debug('authenticatedUser:', authenticatedUser);

    if (!/\S+@\S+\.\S+/.test(email)) {
        setMessage({ type: 'error', text: 'Please enter a valid email address.' });
        return;
    }

    try {
        const updatedUser = {
            id: authenticatedUser.id,
            firstName,
            lastName,
            // Add other required fields
        } as IUserModelUpdate;
        
        await updateUserProfile(updatedUser);  // Use new function
        setMessage({ type: 'success', text: 'Profile updated successfully!' });

        // Force a refresh of the user data
        const auth = JSON.parse(localStorage.getItem('auth') || '{}');
        auth.user = { ...auth.user, firstName, lastName };
        localStorage.setItem('auth', JSON.stringify(auth));
        
        // Trigger auth state change to refresh the UI
        window.dispatchEvent(new Event('authStateChange'));
    } catch (err) {
        console.error('Error updating profile:', err);
        setMessage({ type: 'error', text: 'Failed to update profile.' });
    } finally {
        setLoading(false);
    }
};

//const delay = (ms: number) => new Promise(resolve => setTimeout(resolve, ms));

export default handleUpdateProfile;