using MimeKit;
using TechnologyCenter.Services.Models;

namespace TechnologyCenter.Services.Services
{
    public class Emailservices : IEmailServices
    {
        private readonly EmailConfiguration _emailconfig;

        public Emailservices(EmailConfiguration emailconfig) => _emailconfig = emailconfig;

        public void SendEmail(Message message)
        {
            var emailmessage = CreateEmailMessage(message);
            Send(emailmessage);
        }

        public MimeMessage CreateEmailMessage(Message message)
        {
            var emailmessage = new MimeMessage();
            emailmessage.From.Add(new MailboxAddress("email", _emailconfig.From));
            emailmessage.To.AddRange(message.To);
            message.Subject = message.Subject;
            emailmessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };

            return emailmessage;

        }

        public void Send(MimeMessage mailmessage)
        {
            using var client = new MailKit.Net.Smtp.SmtpClient();
            try
            {
                client.Connect(_emailconfig.SmtpServer, _emailconfig.Port, true);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(_emailconfig.UserName, _emailconfig.Password);

                client.Send(mailmessage);
            }
            catch
            {
                throw;
            }

            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
            var x = _emailconfig.From.ToString();
        }
    }
}

