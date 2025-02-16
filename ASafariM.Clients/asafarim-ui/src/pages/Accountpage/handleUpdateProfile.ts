import { updateUser } from '@/api/userService';
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
        const updatedUser = { ...authenticatedUser, email, firstName, lastName } as IUserModelUpdate;
        console.debug("updatedUser:", updatedUser);
        await updateUser(updatedUser);
        setMessage({ type: 'success', text: 'Profile updated successfully!' });

        await delay(2000);
        setMessage({ type: 'warning', text: 'We will now re-login to let the updated details take effect.' });

        await delay(2000);
        localStorage.removeItem('auth');
        window.dispatchEvent(new Event('authStateChange'));
    } catch (err) {
        console.error('Error updating profile:', err);
        setMessage({ type: 'error', text: 'Failed to update profile.' });
    } finally {
        setLoading(false);
    }
};

const delay = (ms: number) => new Promise(resolve => setTimeout(resolve, ms));

export default handleUpdateProfile;