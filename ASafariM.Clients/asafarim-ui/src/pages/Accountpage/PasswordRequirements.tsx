import React from 'react';

interface PasswordRequirementsProps {
  password: string;
}

const PasswordRequirements: React.FC<PasswordRequirementsProps> = ({ password }) => {
  // Define validation rules
  const minLength = 8;
  const hasUppercase = /[A-Z]/.test(password);
  const hasLowercase = /[a-z]/.test(password);
  const hasNumber = /[0-9]/.test(password);
  const specialChars = /[+_\/@!%*?&]/.test(password);
  const hasMinLength = password.length >= minLength;
  
  // Special characters for display
  const specialCharacters = ['+', '_', '/', '@', '!', '%', '*', '?', '&'];
  
  return (
    <div className="mt-2 p-3 bg-gray-50 rounded-md border border-gray-200">
      <h4 className="text-sm font-semibold mb-2 text-gray-700">Password Requirements:</h4>
      <ul className="space-y-1 text-sm">
        <li className="flex items-center">
          <span className={`inline-flex items-center justify-center w-5 h-5 mr-2 rounded-full ${hasMinLength ? 'bg-green-100 text-green-500' : 'bg-red-100 text-red-500'}`}>
            {hasMinLength ? '✓' : '✗'}
          </span>
          <span>
            At least {minLength} characters
          </span>
        </li>
        <li className="flex items-center">
          <span className={`inline-flex items-center justify-center w-5 h-5 mr-2 rounded-full ${hasUppercase ? 'bg-green-100 text-green-500' : 'bg-red-100 text-red-500'}`}>
            {hasUppercase ? '✓' : '✗'}
          </span>
          <span>
            One uppercase letter (A-Z)
          </span>
        </li>
        <li className="flex items-center">
          <span className={`inline-flex items-center justify-center w-5 h-5 mr-2 rounded-full ${hasLowercase ? 'bg-green-100 text-green-500' : 'bg-red-100 text-red-500'}`}>
            {hasLowercase ? '✓' : '✗'}
          </span>
          <span>
            One lowercase letter (a-z)
          </span>
        </li>
        <li className="flex items-center">
          <span className={`inline-flex items-center justify-center w-5 h-5 mr-2 rounded-full ${hasNumber ? 'bg-green-100 text-green-500' : 'bg-red-100 text-red-500'}`}>
            {hasNumber ? '✓' : '✗'}
          </span>
          <span>
            One number (0-9)
          </span>
        </li>
        <li className="flex items-center">
          <span className={`inline-flex items-center justify-center w-5 h-5 mr-2 rounded-full ${specialChars ? 'bg-green-100 text-green-500' : 'bg-red-100 text-red-500'}`}>
            {specialChars ? '✓' : '✗'}
          </span>
          <span>
            One special character: {' '}
            {specialCharacters.map((char, index) => (
              <span key={index} className="mx-1">{char}</span>
            ))}
          </span>
        </li>
      </ul>
    </div>
  );
};

export default PasswordRequirements;
