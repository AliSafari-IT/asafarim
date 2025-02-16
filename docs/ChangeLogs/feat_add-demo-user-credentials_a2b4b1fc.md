# Add Demo User Credentials and Improve Login Logging

Date: 2025-02-10

Git Commit Hash: a2b4b1fc

# Description of Changes:
- Added demo user credentials for testing purposes:
```typescript
const demoUser = {
  email: "user@example.com",
  password: "User+123456/"
};
```

- Improved login logging with detailed error information:
```typescript
logger.info('Calling login API with email:' + email);
logger.error('Login error: ' + JSON.stringify(err, null, 2));
logger.info('Login process completed. Loading state: ' + loading);
```

- Added UI component to display and autofill demo credentials:
```typescript
<div className="w-full flex flex-col items-center">
  <div className="text-sm text-gray-600 dark:text-gray-300 mb-2">
    Click to autofill demo credentials:
  </div>
  <div 
    className="border border-red-500 p-3 rounded-md bg-gray-50 dark:bg-gray-700 cursor-pointer w-full text-center"
    onClick={() => {
      setEmail(demoUser.email);
      setPassword(demoUser.password);
    }}
  >
    <p className="text-gray-800 dark:text-gray-300"><strong>Email:</strong> {demoUser.email}</p>
    <p className="text-gray-800 dark:text-gray-300"><strong>Password:</strong> {demoUser.password}</p>
  </div>
</div>
```

# Impact:
- Login page UI/UX
- Testing workflow
- Debugging capabilities

# Files Affected:
- src/pages/Accountpage/LoginPage.tsx

# Testing:
- Verify demo credentials can be autofilled
- Ensure login works with demo credentials
- Check logging output in console
