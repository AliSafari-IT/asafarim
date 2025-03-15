using System;
using System.Net;
using System.Text;
using ASafariM.Application.CommandModels;
using ASafariM.Application.Interfaces;
using ASafariM.Application.Services;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using Serilog;

namespace ASafariM.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _smtpHost;
        private readonly int _smtpPort;
        private readonly string _smtpUsername;
        private readonly string _smtpPassword;
        private readonly string _fromDisplayName;

        public EmailService(IConfiguration configuration)
        {
            _smtpHost =
                configuration["Email:SmtpHost"]
                ?? throw new ArgumentNullException("Email:SmtpHost");
            _smtpPort = int.Parse(configuration["Email:SmtpPort"] ?? "465");
            _smtpUsername =
                configuration["Email:SmtpUsername"]
                ?? throw new ArgumentNullException("Email:SmtpUsername");
            _smtpPassword =
                configuration["Email:SmtpPassword"]
                ?? throw new ArgumentNullException("Email:SmtpPassword");
            _fromDisplayName = configuration["Email:FromDisplayName"] ?? "ASafariM Support";
        }

        public void SendReactivationEmail(string email, string reason)
        {
            try
            {
                // Send email to user
                var userMessage = new MimeMessage();
                userMessage.From.Add(new MailboxAddress(_fromDisplayName, _smtpUsername));
                userMessage.To.Add(new MailboxAddress("", email));
                userMessage.Subject = "Account Reactivation Request";

                var userBuilder = new BodyBuilder
                {
                    HtmlBody =
                        $@"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <style>
        body {{ font-family: 'Arial', sans-serif; line-height: 1.6; color: #333; background-color: #f4f4f9; margin: 0; padding: 0; }}
        .container {{ max-width: 600px; margin: 40px auto; padding: 20px; background-color: #ffffff; border-radius: 8px; box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1); }}
        h2 {{ color: #2c3e50; margin-bottom: 20px; font-size: 24px; }}
        .reason {{ background-color: #f8f9fa; padding: 15px; border-radius: 5px; margin: 15px 0; border-left: 4px solid #2c3e50; }}
        .footer {{ margin-top: 30px; color: #666; font-size: 14px; text-align: center; }}
    </style>
</head>
<body>
    <div class='container'>
        <h2>Account Reactivation Request</h2>
        <p>We received a request to reactivate your account.</p>
        <div class='reason'>
            <p><strong>Reason provided:</strong><br>{reason}</p>
        </div>
        <p>Our team will review your request and get back to you shortly.</p>
        <div class='footer'>
            <p>Best regards,<br>ASafariM Team</p>
        </div>
    </div>
</body>
</html>",
                };

                userMessage.Body = userBuilder.ToMessageBody();

                // Send email to admin
                var adminMessage = new MimeMessage();
                adminMessage.From.Add(new MailboxAddress(_fromDisplayName, _smtpUsername));
                adminMessage.To.Add(new MailboxAddress("Admin", _smtpUsername)); // Send to admin email
                adminMessage.Subject = $"[Admin] New Account Reactivation Request - {email}";

                var adminBuilder = new BodyBuilder
                {
                    HtmlBody =
                        $@"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <style>
        body {{ font-family: 'Arial', sans-serif; line-height: 1.6; color: #333; background-color: #f4f4f9; margin: 0; padding: 0; }}
        .container {{ max-width: 600px; margin: 40px auto; padding: 20px; background-color: #ffffff; border-radius: 8px; box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1); }}
        h2 {{ color: #2c3e50; margin-bottom: 20px; font-size: 24px; }}
        .info {{ background-color: #e3f2fd; padding: 15px; border-radius: 5px; margin: 15px 0; border-left: 4px solid #1976d2; }}
        .reason {{ background-color: #f8f9fa; padding: 15px; border-radius: 5px; margin: 15px 0; border-left: 4px solid #2c3e50; }}
        .footer {{ margin-top: 30px; color: #666; font-size: 14px; text-align: center; }}
    </style>
</head>
<body>
    <div class='container'>
        <h2>New Account Reactivation Request</h2>
        <div class='info'>
            <p><strong>User Email:</strong> {email}</p>
            <p><strong>Request Time:</strong> {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC</p>
        </div>
        <div class='reason'>
            <p><strong>Reason provided:</strong><br>{reason}</p>
        </div>
        <p>Please review this request and take appropriate action.</p>
        <div class='footer'>
            <p>ASafariM Admin System</p>
        </div>
    </div>
</body>
</html>",
                };

                adminMessage.Body = adminBuilder.ToMessageBody();

                using var client = new SmtpClient { Timeout = 60000 };

                client.MessageSent += (sender, args) =>
                    Log.Information("Message sent successfully to {Email}", email);

                try
                {
                    Log.Information(
                        "Connecting to SMTP server {Host}:{Port}...",
                        _smtpHost,
                        _smtpPort
                    );

                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.CheckCertificateRevocation = false;

                    client.Connect(_smtpHost, _smtpPort, SecureSocketOptions.SslOnConnect);

                    Log.Information(
                        "Connected to SMTP server. IsConnected: {IsConnected}, IsSecure: {IsSecure}, AuthenticationMechanisms: {Mechanisms}",
                        client.IsConnected,
                        client.IsSecure,
                        string.Join(", ", client.AuthenticationMechanisms)
                    );

                    var credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
                    Log.Information(
                        "Authenticating with SMTP server using {Username}...",
                        _smtpUsername
                    );

                    client.Authenticate(credentials);

                    Log.Information(
                        "Authenticated with SMTP server. IsAuthenticated: {IsAuthenticated}",
                        client.IsAuthenticated
                    );

                    // Send both emails
                    client.Send(userMessage);
                    client.Send(adminMessage);

                    Log.Information("Reactivation emails sent successfully");
                }
                catch (Exception ex)
                {
                    Log.Error(
                        ex,
                        "Error sending reactivation email to {Email}: {Message}. Stack trace: {StackTrace}",
                        email,
                        ex.Message,
                        ex.StackTrace
                    );
                    throw new ApplicationException(
                        $"Failed to send reactivation email: {ex.Message}",
                        ex
                    );
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error in SendReactivationEmail: {Message}", ex.Message);
                throw;
            }
        }

        public void SendPasswordResetEmail(string email, string token)
        {
            try
            {
                // Create reset URL with token
                var resetUrl = $"http://localhost:3000/reset-password?email={email}&token={token}";
                
                // Send email to user
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(_fromDisplayName, _smtpUsername));
                message.To.Add(new MailboxAddress("", email));
                message.Subject = "Password Reset Request";

                var builder = new BodyBuilder
                {
                    HtmlBody = $@"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <style>
        body {{ font-family: 'Arial', sans-serif; line-height: 1.6; color: #333; background-color: #f4f4f9; margin: 0; padding: 0; }}
        .container {{ max-width: 600px; margin: 40px auto; padding: 20px; background-color: #ffffff; border-radius: 8px; box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1); }}
        h2 {{ color: #2c3e50; margin-bottom: 20px; font-size: 24px; }}
        .button {{ display: inline-block; background-color: #3498db; color: white; text-decoration: none; padding: 10px 20px; border-radius: 5px; margin: 20px 0; }}
        .footer {{ margin-top: 30px; color: #666; font-size: 14px; text-align: center; }}
    </style>
</head>
<body>
    <div class='container'>
        <h2>Password Reset Request</h2>
        <p>We received a request to reset your password. Click the button below to reset your password:</p>
        <p><a href='{resetUrl}' class='button'>Reset Password</a></p>
        <p>If you did not request a password reset, please ignore this email or contact support if you have concerns.</p>
        <p>This link will expire in 60 minutes.</p>
        <div class='footer'>
            <p>Best regards,<br>ASafariM Team</p>
        </div>
    </div>
</body>
</html>",
                };

                message.Body = builder.ToMessageBody();

                using var client = new SmtpClient { Timeout = 60000 };

                client.MessageSent += (sender, args) =>
                    Log.Information("Password reset email sent successfully to {Email}", email);

                try
                {
                    Log.Information(
                        "Connecting to SMTP server {Host}:{Port}...",
                        _smtpHost,
                        _smtpPort
                    );

                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.CheckCertificateRevocation = false;

                    client.Connect(_smtpHost, _smtpPort, SecureSocketOptions.SslOnConnect);

                    Log.Information(
                        "Connected to SMTP server. IsConnected: {IsConnected}, IsSecure: {IsSecure}, AuthenticationMechanisms: {Mechanisms}",
                        client.IsConnected,
                        client.IsSecure,
                        string.Join(", ", client.AuthenticationMechanisms)
                    );

                    var credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
                    Log.Information(
                        "Authenticating with SMTP server using {Username}...",
                        _smtpUsername
                    );

                    client.Authenticate(credentials);

                    Log.Information(
                        "Authenticated with SMTP server. IsAuthenticated: {IsAuthenticated}",
                        client.IsAuthenticated
                    );

                    // Send email
                    client.Send(message);

                    Log.Information("Password reset email sent successfully to {Email}", email);
                }
                catch (Exception ex)
                {
                    Log.Error(
                        ex,
                        "Error sending password reset email to {Email}: {Message}. Stack trace: {StackTrace}",
                        email,
                        ex.Message,
                        ex.StackTrace
                    );
                    throw new ApplicationException(
                        $"Failed to send password reset email: {ex.Message}",
                        ex
                    );
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error in SendPasswordResetEmail: {Message}", ex.Message);
                throw;
            }
        }
    }
}
