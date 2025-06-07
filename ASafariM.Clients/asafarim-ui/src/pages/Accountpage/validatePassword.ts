import { logger } from "@/utils/logger";

interface PasswordValidationResult {
  isValid: boolean;
  errors: {
    length: boolean;
    uppercase: boolean;
    lowercase: boolean;
    number: boolean;
    specialChar: boolean;
  };
}

export const validatePassword = (password: string): PasswordValidationResult => {
  logger.info('Validating password');
  
  // Define validation rules
  const minLength = 8;
  const hasUppercase = /[A-Z]/.test(password);
  const hasLowercase = /[a-z]/.test(password);
  const hasNumber = /[0-9]/.test(password);
  const specialChars = /[+_\/@!%*?&]/.test(password);
  const hasMinLength = password.length >= minLength;
  
  // Check if all conditions are met
  const isValid = hasMinLength && hasUppercase && hasLowercase && hasNumber && specialChars;
  
  // Return detailed validation result
  return {
    isValid,
    errors: {
      length: !hasMinLength,
      uppercase: !hasUppercase,
      lowercase: !hasLowercase,
      number: !hasNumber,
      specialChar: !specialChars
    }
  };
};

// Helper function to get a user-friendly error message
export const getPasswordValidationMessage = (result: PasswordValidationResult): string => {
  if (result.isValid) return '';
  
  const specialCharacters = ['+', '_', '/', '@', '!', '%', '*', '?', '&'];
  const messages: string[] = [];
  
  if (result.errors.length) {
    messages.push('at least 8 characters');
  }
  if (result.errors.uppercase) {
    messages.push('1 uppercase letter');
  }
  if (result.errors.lowercase) {
    messages.push('1 lowercase letter');
  }
  if (result.errors.number) {
    messages.push('1 number');
  }
  if (result.errors.specialChar) {
    messages.push(`1 special character (${specialCharacters.join(' ')})`);
  }
  
  if (messages.length === 1) {
    return `Password must include ${messages[0]}`;
  }
  
  return `Password must include: ${messages.join(', ')}`;
};