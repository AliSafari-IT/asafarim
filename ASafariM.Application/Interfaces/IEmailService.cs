using System;

namespace ASafariM.Application.Interfaces
{
    public interface IEmailService
    {
        void SendReactivationEmail(
            string email,
            string reason = "User believes this Account Deleted by mistake!"
        );

        void SendPasswordResetEmail(string email, string token);
    }
}
