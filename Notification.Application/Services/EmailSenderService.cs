using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MimeKit;
using Notification.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Application.Services
{
    public class EmailSenderService(IConfiguration configuration, ILogger<EmailSenderService> logger) : IEmailSenderService
    {
        public async Task sendEmail(string emailTo)
        {
            try
            {
                var emailFrom = configuration["email:Sender"];
                var username = configuration["email:username"];
                var stmp = configuration["email:stmp"];
                int.TryParse(configuration["email:port"],out int port);
                var password = configuration["email:password"];
                bool.TryParse(configuration["email:UseSSL"],out bool UseSSL);



                MimeMessage email_Message = new MimeMessage();
                MailboxAddress email_From = new MailboxAddress("Sender", emailFrom);
                email_Message.From.Add(email_From);
                MailboxAddress email_To = new MailboxAddress("user", emailTo);
                email_Message.To.Add(email_To);
                email_Message.Subject = "Test";
                BodyBuilder emailBodyBuilder = new BodyBuilder();
                emailBodyBuilder.TextBody = "Notification";
                email_Message.Body = emailBodyBuilder.ToMessageBody();
                //this is the SmtpClient class from the Mailkit.Net.Smtp namespace, not the System.Net.Mail one
                SmtpClient MailClient = new SmtpClient();
                MailClient.Connect(stmp, port, UseSSL);
                MailClient.Authenticate(username, password);
                MailClient.Send(email_Message);
                MailClient.Disconnect(true);
                MailClient.Dispose();
            }
            catch (Exception ex) 
            { 
                logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
