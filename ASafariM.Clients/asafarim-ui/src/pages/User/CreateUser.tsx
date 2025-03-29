import React, { useCallback, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import Wrapper from '@/layout/Wrapper/Wrapper';
import Footer from '@/layout/Footer/Footer';
import Header from '@/layout/Header/Header';
import { IField } from '@/interfaces';
import { addUserByAdmin } from '@/api/userManagerApi';
import AddForm from '@/components/crud/AddForm';
import { IFormData } from '@/interfaces/IFormData';
import { useAuth } from '@/contexts/AuthContext';
import { isAxiosError } from 'axios';
import axios from 'axios';
import { debounce } from 'lodash';
import { ICreateUserModel } from '@/interfaces/ICreateUserModel';
import { logger } from '@/utils/logger';

const CreateUser: React.FC = () => {
  const navigate = useNavigate();
  const [error, setError] = useState<string | null>(null);
  // availability is a simple object that will store whether a field is available or not
  const [availability, setAvailability] = useState({
    userName: null as boolean | null,
    email: null as boolean | null,
  });
  const { authenticatedUser } = useAuth(); // Assuming this returns the current user

   /**
   * Debounce the availability check so that we wait ~500ms
   * after the user stops typing before hitting the server
   */
   const checkAvailability = useCallback(
    debounce(async (field: 'userName' | 'email', value: string) => {
      if (!value) return;

      try {
        const { data } = await axios.get('/api/users/check-availability/validate', {
          params: { [field]: value },
        });

        // data is assumed to have shape: { isAvailable: boolean, messages: string[] }
        setAvailability((prev) => ({ ...prev, [field]: data.isAvailable }));
      } catch (err) {
        logger.error(`Error checking ${field} availability:`, err);
      }
    }, 500),
    []
  );

   /**
   * We define the fields for the AddForm, mapping availability to either `error` or `success`.
   * If availability[field] === false => that means taken => error message
   * If availability[field] === true  => that means available => success message
   */
   const fields: IField[] = [
    { name: 'firstName', label: 'First Name', type: 'text', required: true ,
      validate: validateFirstName
    },
    { name: 'lastName', label: 'Last Name', type: 'text', required: true ,
      validate: validateLastName
    },
    {
      name: 'userName',
      label: 'User Name',
      type: 'text',
      required: true,
      onChange: (e: React.ChangeEvent<HTMLInputElement>) => checkAvailability('userName', e.target.value),
      error: availability.userName === false ? 'Username is already taken' : undefined,
      success: availability.userName === true ? 'Username is available' : undefined,
      validate: validateUserName
    },
    {
      name: 'email',
      label: 'Email',
      type: 'email',
      required: true,
      onChange: (e: React.ChangeEvent<HTMLInputElement>) => checkAvailability('email', e.target.value),
      error: availability.email === false ? 'Email is already registered' : undefined,
      success: availability.email === true ? 'Email is available' : undefined,
      validate: validateEmail
    },
    { name: 'dateOfBirth', label: 'Date of Birth', type: 'date', required: true },
    { name: 'bio', label: 'Bio', type: 'textarea', defaultValue: '' },
    { name: 'profilePicture', label: 'Profile Picture URL', type: 'text', defaultValue: '' },
    { name: 'remark', label: 'Remark', type: 'text', defaultValue: '' },
    {
      name: 'isAdmin',
      label: 'Is Admin',
      type: 'radio',
      options: [
        { value: 'true', label: 'Yes' },
        { value: 'false', label: 'No' },
      ],
      required: true,
      defaultValue: 'false',
      disabled: true,
    },
    {
      name: 'isActive',
      label: 'Is Active',
      type: 'checkbox',
      disabled: true,
      defaultValue: true,
    },
    {
      name: 'createdBy',
      label: 'Created By',
      type: 'text',
      disabled: true,
      defaultValue: authenticatedUser?.id || '',
    },
    {
      name: 'password',
      label: 'Password',
      type: 'password',
      required: true,
    },
  ];

  function validateFirstName(value: string | number | boolean |  undefined | File | FileList): string | undefined {
    if (typeof value === 'string' && value.trim().length < 2) {
      return "First Name must be at least 2 characters.";
    }
    return undefined; // no error
  }
  
  function validateLastName(value: string | number | boolean | undefined | File | FileList): string | undefined {
    if (typeof value === 'string' && value.trim().length < 1) {
      return "Last Name is required.";
    }
    return undefined;
  }
  
  function validateEmail(value: string | number | boolean | undefined | File | FileList): string | undefined {
    if (typeof value === 'string' && (!value || !/\S+@\S+\.\S+/.test(value))) {
      return "Invalid email address.";
    }
    return undefined;
  }
  
  function validateUserName(value: string | number | boolean | undefined | File | FileList): string | undefined {
    if (typeof value === 'string' && value.trim().length < 3) {
      return "User Name must be at least 3 characters.";
    }
    return undefined;
  }

  const convertFormDataToIFormData = (formData: FormData): IFormData => {
    return {
        firstName: formData.get('firstName') as string,
        lastName: formData.get('lastName') as string,
        email: formData.get('email') as string,
        userName: formData.get('userName') as string,
        bio: formData.get('bio') as string || "",
        profilePicture: formData.get('profilePicture') as string || "",
        remark: formData.get('remark') as string || "",
        isAdmin: formData.get('isAdmin') as string === 'true',
        isActive: formData.get('isActive') as string === 'true',
        dateOfBirth: formData.get('dateOfBirth') as string,
        createdBy: formData.get('createdBy') as string,
        password: formData.get('password') as string,
        updatedBy: formData.get('createdBy') as string
    };
};

  // Helper function to format date as yyyy-MM-dd
  const formatDate = (dateString: string): string => {
    const date = new Date(dateString);
    const year = date.getFullYear();
    const month = String(date.getMonth() + 1).padStart(2, '0');
    const day = String(date.getDate()).padStart(2, '0');
    return `${year}-${month}-${day}`;
  };

// Usage in handleSubmit
const handleSubmit = async (formData: FormData): Promise<void> => {
    const iFormData = convertFormDataToIFormData(formData);

    try {
      // Transform form data to match API expectations
      const dateOfBirth = iFormData.dateOfBirth 
        ? formatDate(iFormData.dateOfBirth as string)
        : undefined;
      
      const userData: ICreateUserModel = {
        firstName: iFormData.firstName as string,
        lastName: iFormData.lastName as string,
        email: iFormData.email as string,
        userName: iFormData.userName as string,
        password: iFormData.password as string || "P@ssw0rd+",
        dateOfBirth,
        profilePicture: iFormData.profilePicture as string || "",
        isAdmin: Boolean(iFormData.isAdmin)
      };

      logger.debug("Transformed user data before API call:", userData);
      // Call addUserByAdmin API instead of createUser
      const result = await addUserByAdmin(userData);
      logger.debug("User creation result:", result);
      
      if (result && result.success) {
        logger.debug("User created successfully:", result.data);
        navigate('/users');
      } else {
        logger.debug("Failed to create user:", result);
        setError("Failed to create user. Please try again.");
      }
    } catch (error) {
      // Handle error
      if (isAxiosError(error)) {
        logger.error("Axios error:", error);
        setError(error.response?.data?.message || error.message || "Failed to create user. Please try again.");
      } else {
        logger.error("Unknown error:", error);
        setError("Failed to create user. Please try again.");
      }
    }
  };
  
  function handleCancel(): void {
    navigate('/users');
  }

return (
  <Wrapper
    header={<Header children={<h1 className="w-full text-xl font-bold text-center text-[var(--text-info)]">Add New User</h1>} />}
    footer={<Footer />}
  >
    <div className="w-full max-w-6xl mx-auto px-4 sm:px-6 lg:px-8 py-4 sm:py-6">
      <div className="rounded-lg shadow-lg p-4 sm:p-6 lg:p-8 transition duration-300 ease-in-out add-form">
        {error && <p className="text-red-500 text-sm mb-4 error-message">{error}</p>}
        <AddForm 
          entityName="User" 
          fields={fields} 
          submitHandler={handleSubmit} 
          onCancel={handleCancel} 
          className="transition-all duration-300 ease-in-out add-form"
        />
      </div>
    </div>
  </Wrapper>
);
};

export default CreateUser;
