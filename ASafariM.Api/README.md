# ASafariM.Api

## Configuration Setup

### Local Development
1. Copy `appsettings.json.template` to create your `appsettings.json`:
   ```bash
   cp appsettings.json.template appsettings.json
   ```

2. Update `appsettings.json` with your actual values:
   - Database connection string
   - SMTP settings
   - Any other environment-specific settings

3. Never commit `appsettings.json` to the repository (it's already in .gitignore)

### Production Environment
For production, use environment variables or a secure secrets management system. Never store sensitive credentials in the repository.

The following configuration values are required:
- ConnectionStrings:DefaultConnection
- SmtpSettings:Server
- SmtpSettings:Port
- SmtpSettings:Username
- SmtpSettings:Password
- SmtpSettings:EnableSsl
- SmtpSettings:FromEmail
- SmtpSettings:FromName
