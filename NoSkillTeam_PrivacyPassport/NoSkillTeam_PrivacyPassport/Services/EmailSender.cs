using Microsoft.Extensions.Options;
using NoSkillTeam_PrivacyPassport.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace NoSkillTeam_PrivacyPassport.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly SendGridOptions _options;

        public EmailSender(IOptions<SendGridOptions> options)
        {
            _options = options.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var apiKey = _options.ApiKey;
            var client = new SendGridClient(apiKey);

            var msg = new SendGridMessage()
            {
                From = new EmailAddress(_options.FromEmail, _options.FromName),
                Subject = subject,
                HtmlContent = message
            };

            msg.AddTo(new EmailAddress(email));

            var response = await client.SendEmailAsync(msg);

            return;
        }
    }
}
